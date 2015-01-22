using System;
using OSGeo.GDAL;

namespace Maplayer
{
    class GDALRead
    {
        public static int GetXSize(String fileName)
        {
            Gdal.AllRegister();

            Dataset dataset = Gdal.Open(fileName, Access.GA_ReadOnly);
            Band band = dataset.GetRasterBand(1);
            return band.XSize;
        }

        public static int GetYSize(String fileName)
        {
            Gdal.AllRegister();

            Dataset dataset = Gdal.Open(fileName, Access.GA_ReadOnly);
            Band band = dataset.GetRasterBand(1);
            return band.YSize;
        }

        public static int[] ReadIntDataset(String fileName)
        {
            Gdal.AllRegister();

            Dataset dataset = Gdal.Open(fileName, Access.GA_ReadOnly);
            Band band = dataset.GetRasterBand(1);
            int width  = band.XSize;
            int height = band.YSize;
            int[] buffer = new int[width * height];
            band.ReadRaster(0, 0, width, height, buffer, width, height, 0, 0);

            return buffer;
        }
    }
}
