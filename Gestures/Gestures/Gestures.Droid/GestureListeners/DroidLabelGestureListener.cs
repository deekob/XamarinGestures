using System;

using Android.Views;

namespace Gestures.Droid.GestureListeners
{
    class DroidLabelGestureListener : GestureDetector.SimpleOnGestureListener
    {
        public override bool OnDoubleTap(MotionEvent e)
        {
            Console.WriteLine("OnDoubleTap");
            return base.OnDoubleTap(e);
        }

        public override bool OnContextClick(MotionEvent e)
        {
            Console.WriteLine("OnContextClick");
            return base.OnContextClick(e);
        }

        public override bool OnDown(MotionEvent e)
        {
            Console.WriteLine("OnDown");
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
            return base.OnSingleTapConfirmed(e);
        }

        public override bool OnSingleTapUp(MotionEvent e)
        {
            Console.WriteLine("OnSingleTapUp");
            return base.OnSingleTapUp(e);
        }

        public override bool OnDoubleTapEvent(MotionEvent e)
        {
            Console.WriteLine("OnDoubleTapEvent");
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
            
            base.OnLongPress(e);
        }

        public override void OnShowPress(MotionEvent e)
        {
            Console.WriteLine("OnShowPress");
            base.OnShowPress(e);
        }
    }
}