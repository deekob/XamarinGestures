using System;
using Gestures.CustomControls;
using Gestures.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomButton), typeof(IosButtonRenderer))]
namespace Gestures.iOS.Renderers
{
    class IosButtonRenderer : ButtonRenderer
    {
        UILongPressGestureRecognizer _longPressGestureRecognizer;
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            _longPressGestureRecognizer = new UILongPressGestureRecognizer(() => LongPressFired());

            if (e.NewElement == null)
            {
                if (_longPressGestureRecognizer != null)
                {
                    this.RemoveGestureRecognizer(_longPressGestureRecognizer);
                }
            }

            if (e.OldElement == null)
            {
                this.AddGestureRecognizer(_longPressGestureRecognizer);
            }
        }

        private void LongPressFired()
        {
          Button element = this.Element;
          
          if (element == null)
                return;
            element.Text = "clicked";
          ((IButtonController)element).SendClicked();
        }


    }
}