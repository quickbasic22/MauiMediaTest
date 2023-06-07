using CommunityToolkit.Maui.Animations;
using CommunityToolkit.Maui.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMediaTest
{
    public class PaintTheRainbowAnimation : BaseAnimation
    {
        public override async Task Animate(VisualElement view)
        {
            this.Length = 2000u;
            
            await view.BackgroundColorTo(Color.FromHex("dfff11"));
            await view.BackgroundColorTo(Color.FromHex("66ff00"));
            await view.BackgroundColorTo(Color.FromHex("ff08e8"));
            await view.BackgroundColorTo(Color.FromHex("fe01b1"));
            await view.BackgroundColorTo(Color.FromHex("be03fd"));
            await view.BackgroundColorTo(Color.FromHex("ff000d"));
            await view.BackgroundColorTo(Color.FromHex("ffcf09"));
            await view.BackgroundColorTo(Color.FromHex("ffcf09"));
            await view.BackgroundColorTo(Color.FromHex("fc0e34"));
            await view.BackgroundColorTo(Color.FromHex("01f9c6"));
            
        }
    }
}
