using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace DevPF.Views
{
    public partial class ucMainPicture : DevExpress.XtraEditors.XtraUserControl
    {
        public ucMainPicture()
        {
            InitializeComponent();
            WorkingFolder = DataPath;
            InitializeContent();
          //  SetImage(Images[0]);
        }

        protected virtual void InitializeContent()
        {
            InitializeTileControl();
        }
        protected virtual void InitializeTileControl()
        {
            (tileControl as ITileControl).ViewInfo.UseAdvancedTextRendering = false;
            if (TileGroupImages == null) return;
            TileControl.Groups.Clear();
            TileControl.Groups.Add(TileGroupImages);
        }
        protected virtual void InitializeImages()
        {
            if (string.IsNullOrEmpty(WorkingFolder)) return;
            Images = new List<Image>();
            string[] files = Directory.GetFiles(WorkingFolder, "*.jpg");
            foreach (string file in files)
            {
                Image img = Bitmap.FromFile(file);
                img.Tag = file;
                Images.Add(img);
            }
            InitializeTileControl();
        }
        protected virtual List<Image> Images { get; set; }
        protected virtual TileControl TileControl { get { return tileControl; } }
        protected virtual PictureEdit PictureEdit { get { return peCurrentImage; } }

        Image currentImage;
        protected virtual Image CurrentImage
        {
            get { return currentImage; }
            set
            {
                currentImage = value;
                if (CurrentImage == null) return;
                PictureEdit.Image = CurrentImage;
                CalcCurrentImageZoomPercent(currentImage);
            }
        }
        protected virtual void CalcCurrentImageZoomPercent(Image img)
        {
            PictureEdit.Properties.ZoomPercent = Math.Min(((double)PictureEdit.Height / (double)img.Height) * 100, 100);
        }
        string workingFolder;
        protected virtual string WorkingFolder
        {
            get { return workingFolder; }
            set
            {
                if (workingFolder == value) return;
                workingFolder = value;
                InitializeImages();
            }
        }
        TileGroup group;
        protected virtual TileGroup TileGroupImages
        {
            get
            {
                if (group == null)
                    group = CreateTileGroupImages();
                return group;
            }
        }
        protected virtual void SetImage(Image img)
        {
            CurrentImage = img;
        }
        protected string GetDataDir()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            for (int i = 0; i < 10; i++)
            {
                path += "..\\";
                if (Directory.Exists(path + "Data"))
                    return path + "Data";
            }
            return string.Empty;
        }
        protected string DataPath
        {
            get
            {
                // string dataPath = GetDataDir() + "\\AccordionControlData";
                string dataPath = Application.StartupPath + "\\AccordionControlData";
                
                if (Directory.Exists(dataPath))
                    return dataPath;
                return string.Empty;
            }
        }

        protected virtual TileGroup CreateTileGroupImages()
        {
            if (Images == null || Images.Count == 0) return null;
            TileGroup g = new TileGroup();
            foreach (Image img in Images)
            {
                TileItem item = new TileItem() { BackgroundImage = img, BackgroundImageScaleMode = TileItemImageScaleMode.Squeeze, BackgroundImageAlignment = TileItemContentAlignment.MiddleCenter };
                g.Items.Add(item);
            }
            return g;
        }

        protected virtual void OnPictureEditCurrentImageSizeChanged(object sender, EventArgs e)
        {
            if (CurrentImage == null) return;
            CalcCurrentImageZoomPercent(CurrentImage);
        }

        protected virtual void OnTileControlItemClick(object sender, TileItemEventArgs e)
        {
            SetImage(e.Item.BackgroundImage);
        }
        #region Filters
        List<FilterBase> filterList;
        protected virtual List<FilterBase> FilterList
        {
            get
            {
                if (filterList == null)
                {
                    filterList = new List<FilterBase>(){
                        new PolaroidFilter(),
                        new BGRFilter(),
                        new GBRFilter(),
                        new SepiaFilter(),
                        new GrayScaleFilter(),
                        new NegativeFilter(),
                    };
                }
                return filterList;
            }
        }
        UniversalFilter universalFilter;
        protected virtual UniversalFilter UniversalFilter
        {
            get
            {
                if (universalFilter == null)
                    universalFilter = new UniversalFilter();
                return universalFilter;
            }
        }
        ContrastFilter contrastFilter;
        protected virtual ContrastFilter ContrastFilter
        {
            get
            {
                if (contrastFilter == null)
                    contrastFilter = new ContrastFilter();
                return contrastFilter;
            }
        }
        #endregion
   
    }
    public static class ImageHelper
    {
        public static string GetDimension(Image img)
        {
            if (img == null) return "0x0";
            return string.Format("{0}x{1}", img.Width, img.Height);
        }
        public static string GetName(Image img)
        {
            if (img == null) return string.Empty;
            return Path.GetFileName(img.Tag.ToString());
        }
        public static string GetSize(Image img)
        {
            if (img == null) return "0 KB";
            return (new FileInfo(img.Tag.ToString()).Length / 1024).ToString() + " KB";
        }
        public static int GetRating(Image img)
        {
            if (img == null) return 0;
            PropertyItem prop;
            try
            {
                prop = img.GetPropertyItem(18246);
            }
            catch
            {
                return 0;
            }
            if (prop == null) return 0;
            return BitConverter.ToInt16(prop.Value, 0);
        }
    }
    public delegate void GalleryItemApplyFilter(string name, Image image, FilterBase filter);
    public class FilterBase
    {
        public virtual string Name { get { return string.Empty; } }
        public Image ApplyFilter(Image image, Size size)
        {
            return ApplyMatrix(image, size, Matrix);
        }
        protected virtual ColorMatrix Matrix { get { return new ColorMatrix(); } }
        protected Bitmap ApplyMatrix(Image image, Size size, ColorMatrix matrix)
        {
            Bitmap src = new Bitmap(image, size);
            Bitmap dest = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);
            using (Graphics graphics = Graphics.FromImage(dest))
            {
                ImageAttributes bmpAttributes = new ImageAttributes();
                bmpAttributes.SetColorMatrix(matrix);
                graphics.DrawImage(src, new Rectangle(0, 0, src.Width, src.Height), 0, 0, src.Width, src.Height, GraphicsUnit.Pixel, bmpAttributes);
            }
            src.Dispose();
            return dest;
        }
    }
    public class PolaroidFilter : FilterBase
    {
        public override string Name { get { return "Polaroid"; } }
        protected override ColorMatrix Matrix
        {
            get
            {
                return new ColorMatrix(new float[][] {
                    new float[] {1.438f, -0.062f, -0.062f, 0, 0},
                    new float[] {-0.122f, 1.378f, -0.122f, 0, 0},
                    new float[] {0.016f, -0.016f, 1.438f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0.03f, 0.05f, -0.2f, 0, 1}
                });
            }
        }
    }
    public class GrayScaleFilter : FilterBase
    {
        public override string Name { get { return "GrayScale"; } }
        protected override ColorMatrix Matrix
        {
            get
            {
                return new ColorMatrix(new float[][] {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
            }
        }
    }
    public class NegativeFilter : FilterBase
    {
        public override string Name { get { return "Negative"; } }
        protected override ColorMatrix Matrix
        {
            get
            {
                return new ColorMatrix(new float[][] {
                    new float[] {-1, 0, 0, 0, 0},
                    new float[] {0, -1, 0, 0, 0},
                    new float[] {0, 0, -1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {1, 1, 1, 0, 1}
                });
            }
        }
    }
    public class SepiaFilter : FilterBase
    {
        public override string Name { get { return "Sepia"; } }
        protected override ColorMatrix Matrix
        {
            get
            {
                return new ColorMatrix(new float[][] {
                    new float[] {.393f, .349f, .272f, 0, 0},
                    new float[] {.769f, .686f, .534f, 0, 0},
                    new float[] {.189f, .168f, .131f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
            }
        }
    }
    public class BGRFilter : FilterBase
    {
        public override string Name { get { return "BGR"; } }
        protected override ColorMatrix Matrix
        {
            get
            {
                return new ColorMatrix(new float[][] {
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
            }
        }
    }
    public class GBRFilter : FilterBase
    {
        public override string Name { get { return "GBR"; } }
        protected override ColorMatrix Matrix
        {
            get
            {
                return new ColorMatrix(new float[][] {
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
            }
        }
    }
    public class UniversalFilter : FilterBase
    {
        public UniversalFilter()
        {
            r = g = b = 0;
        }
        int r, g, b;
        public Image ApplyFilter(Image image, Size size, int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            return ApplyMatrix(image, size, Matrix);
        }
        public override string Name { get { return "Universal"; } }
        protected override ColorMatrix Matrix
        {
            get
            {
                return new ColorMatrix(new float[][] {
                    new float[] {1 + (float)(r / 255.0f), 0, 0, 0, 0},
                    new float[] {0, 1 + (float)(g/ 255.0f), 0, 0, 0},
                    new float[] {0, 0, 1 + (float)(b/ 255.0f), 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0.1f, 0.1f, 0.1f, 0, 1}
                });
            }
        }
    }
    public class ContrastFilter : FilterBase
    {
        public ContrastFilter()
        {
            scale = translate = 0;
        }
        float scale;
        float translate;
        public override string Name { get { return "Contrast"; } }
        public Image ApplyFilter(Image image, Size size, int val)
        {
            scale = val;
            translate = (-.5f * scale + .5f) * 255.0f;
            return ApplyMatrix(image, size, Matrix);
        }
        protected override ColorMatrix Matrix
        {
            get
            {
                return new ColorMatrix(new float[][] {
                    new float[] {1 + scale / 100, 0, 0, 0, translate},
                    new float[] {0, 1 + scale / 100, 0, 0, translate},
                    new float[] {0, 0, 1 + scale / 100, 0, translate},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
            }
        }
    }
}
