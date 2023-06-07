using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MauiMediaTest
{
    public class Drawable : IDrawable, IAnimatable
    {
        private Color fillColor = Colors.Red;
        public GraphicsView graphicsView; // Reference to the GraphicsView
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            PathF path = new PathF();
            for (int i = 0; i < 11; i++)
            {
                double angle = 5 * i * 2 * Math.PI / 11;
                PointF point = new PointF(100 * (float)Math.Sin(angle), -100 * (float)Math.Cos(angle));
                if (i == 0)
                    path.MoveTo(point);
                else
                    path.LineTo(point);
            }
            canvas.FillColor = Colors.Red;
            canvas.Translate(800, 350);
            canvas.Scale(3f, 3f);
            canvas.SetShadow(new SizeF(400f, 200f), 100f, Color.FromRgba(128, 255, 128, 255));

            canvas.FillPath(path);
        }

        public void AnimateFillColor(Color targetColor)
        {
            
            Animation animation = new Animation(
                callback: (progress) =>
                {
                    int currentR = (int)(fillColor.Red * (1 - progress) + targetColor.Red * progress);
                    int currentG = (int)(fillColor.Green * (1 - progress) + targetColor.Green * progress);
                    int currentB = (int)(fillColor.Blue * (1 - progress) + targetColor.Blue * progress);
                    int currentA = (int)(fillColor.Alpha * (1 - progress) + targetColor.Alpha * progress);

                    fillColor = Color.FromRgba(currentR, currentG, currentB, currentA);

                    // Redraw the UI on the main thread
                    graphicsView?.Dispatcher.Dispatch(() =>
                    {
                        graphicsView.Invalidate();
                    });
                                       
                },
                start: 0,
                end: 1,
                easing: Easing.Linear);

            animation.Commit(this, "FillColorAnimation", repeat: () => true);
        }

        public void BatchBegin()
        {
            
            throw new NotImplementedException();
        }

        public void BatchCommit()
        {
            throw new NotImplementedException();
        }
    }
}
