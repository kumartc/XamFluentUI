﻿using System;
using Xamarin.Forms;

namespace Fluent
{
    public static class ScrollViewExtensions
    {
        public static ScrollView Content(this ScrollView scrollView, Func<View> view)
        {
            scrollView.Content = view.Invoke();
            return scrollView;
        }

        public static ScrollView ScrollBarVisibility(this ScrollView scrollView,
            ScrollBarVisibility horizontal = default(ScrollBarVisibility),
            ScrollBarVisibility vertical = default(ScrollBarVisibility))
        {
            scrollView.HorizontalScrollBarVisibility = horizontal;
            scrollView.VerticalScrollBarVisibility = vertical;
            return scrollView;
        }

        public static ScrollView Orientation(this ScrollView scrollView, ScrollOrientation orientation)
        {
            scrollView.Orientation = orientation;
            return scrollView;
        }
    }
}