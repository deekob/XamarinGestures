using System;
using Android.Graphics;
using Android.Views;
using Gestures.Droid.Renderers;
using Xamarin.Forms.Platform.Android;

namespace Gestures.Droid.GestureListeners
{
    class DroidButtonGestureListener : GestureDetector.SimpleOnGestureListener
    {
        private DroidButtonRenderer _render;
        private MotionEvent _lastEvent;

        public DroidButtonGestureListener(DroidButtonRenderer renderer)
        {
            _render = renderer;
        }



        public override bool OnDoubleTap(MotionEvent e)
        {
            Console.WriteLine("OnDoubleTap");
            _lastEvent = e;
            return base.OnDoubleTap(e);
        }

        public override bool OnContextClick(MotionEvent e)
        {
            Console.WriteLine("OnContextClick");
            _lastEvent = e;

            return base.OnContextClick(e);
        }

        public override bool OnDown(MotionEvent e)
        {
            Console.WriteLine("OnDown");
            _lastEvent = e;

            return base.OnDown(e);
        }

        public override bool OnScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY)
        {
            Console.WriteLine("OnScroll");
      
            return base.OnScroll(e1, e2, distanceX, distanceY);
        }

        public override bool OnSingleTapConfirmed(MotionEvent e)
        {
            Console.WriteLine("OnSingleTapConfirmed");
            _lastEvent = e;

            return base.OnSingleTapConfirmed(e);
        }

        public override bool OnSingleTapUp(MotionEvent e)
        {
            Console.WriteLine("OnSingleTapUp");
            _lastEvent = e;

            return base.OnSingleTapUp(e);
        }

        public override bool OnDoubleTapEvent(MotionEvent e)
        {
            Console.WriteLine("OnDoubleTapEvent");
            _lastEvent = e;

            return base.OnDoubleTapEvent(e);
        }

        public override bool OnFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
        {
            Console.WriteLine("OnFling");
            return base.OnFling(e1, e2, velocityX, velocityY);
        }

        public override void OnLongPress(MotionEvent e)
        {
            Console.WriteLine("OnLongPress");
            _lastEvent = e;
            _render.FireLongPress();
            base.OnLongPress(e);
        }

        public override void OnShowPress(MotionEvent e)
        {
            Console.WriteLine("OnShowPress");
            _lastEvent = e;

            base.OnShowPress(e);
        }
    }
}
