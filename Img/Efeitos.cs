using System;
using System.Drawing;

public class Efeitos
{
    #region Grid
    public Bitmap gride(Bitmap tempBm)
    {
        Bitmap bm = new Bitmap(tempBm);

        Color colorPx;

        //width
        for (int i = 170; i < 215; i += 1)
        {
            //height
            for (int j = 165; j < 215; j += 1)
            {
                colorPx = bm.GetPixel(i, j);

                int pixelR = colorPx.R;
                int pixelG = colorPx.G - 255;
                int pixelB = colorPx.B - 255;

                pixelR = Math.Max(pixelR, 0);
                pixelR = Math.Min(255, pixelR);

                pixelG = Math.Max(pixelG, 0);
                pixelG = Math.Min(255, pixelG);

                pixelB = Math.Max(pixelB, 0);
                pixelB = Math.Min(255, pixelB);

                if (colorPx.R < 180)
                {
                    bm.SetPixel(i, j, Color.FromArgb((byte)pixelR, (byte)pixelG, (byte)pixelB));
                }
            }
        }

        return bm;
    }
    #endregion

    #region Vermelho
    public Bitmap vermelho(Bitmap tempBm)
    {

        Bitmap bm = new Bitmap(tempBm);
        Color colorPx;

        for (int i = 0; i < bm.Width; i++)
        {

            for (int j = 0; j < bm.Height; j++)
            {

                colorPx = bm.GetPixel(i, j);

                int pixelR = colorPx.R;
                int pixelG = colorPx.G;
                int pixelB = colorPx.B;

                pixelR = colorPx.R;
                pixelG = colorPx.G - 255;
                pixelB = colorPx.B - 255;

                pixelR = Math.Max(pixelR, 0);
                pixelR = Math.Min(255, pixelR);

                pixelG = Math.Max(pixelG, 0);
                pixelG = Math.Min(255, pixelG);

                pixelB = Math.Max(pixelB, 0);
                pixelB = Math.Min(255, pixelB);

                bm.SetPixel(i, j, Color.FromArgb((byte)pixelR, (byte)pixelG, (byte)pixelB));
            }
        }

        return bm;
    }
    #endregion

    #region Verde
    public Bitmap verde(Bitmap tempBm)
    {

        Bitmap bm = new Bitmap(tempBm);
        Color colorPx;

        for (int i = 0; i < bm.Width; i++)
        {

            for (int j = 0; j < bm.Height; j++)
            {
                colorPx = bm.GetPixel(i, j);

                int pixelR = (colorPx.R + colorPx.G + colorPx.B) / 3;

                bm.SetPixel(i, j, Color.FromArgb((byte)pixelR, (byte)pixelR, (byte)pixelR));
            }
        }

        return bm;
    }
    #endregion

    #region Azul
    public Bitmap azul(Bitmap tempBm)
    {

        Bitmap bm = new Bitmap(tempBm);
        Color colorPx;

        for (int i = 0; i < bm.Width; i++)
        {

            for (int j = 0; j < bm.Height; j++)
            {
                colorPx = bm.GetPixel(i, j);

                int pixelR = colorPx.R - 255;
                int pixelG = colorPx.G - 255;
                int pixelB = colorPx.B;

                pixelR = Math.Max(pixelR, 0);
                pixelR = Math.Min(255, pixelR);

                pixelG = Math.Max(pixelG, 0);
                pixelG = Math.Min(255, pixelG);

                pixelB = Math.Max(pixelB, 0);
                pixelB = Math.Min(255, pixelB);

                bm.SetPixel(i, j, Color.FromArgb((byte)pixelR, (byte)pixelG, (byte)pixelB));
            }
        }

        return bm;
    }
    #endregion
}