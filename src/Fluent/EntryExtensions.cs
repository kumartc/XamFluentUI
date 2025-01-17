﻿using System.Windows.Input;
using Xamarin.Forms;

namespace Fluent
{
    public static class EntryExtensions
    {
        public static Entry CursorPosition(this Entry entry, int position)
        {
            entry.CursorPosition = position;
            return entry;
        }

        public static Entry FontAttributes(this Entry entry, FontAttributes attributes)
        {
            entry.FontAttributes = attributes;
            return entry;
        }

        public static Entry FontFamily(this Entry entry, string fontFamily)
        {
            entry.FontFamily = fontFamily;
            return entry;
        }

        public static Entry FontSize(this Entry entry, double fontSize)
        {
            entry.FontSize = fontSize;
            return entry;
        }

        public static Entry HorizontalTextAlignment(this Entry entry, TextAlignment alignment)
        {
            entry.HorizontalTextAlignment = alignment;
            return entry;
        }

        public static Entry IsPassword(this Entry entry, bool isPassword)
        {
            entry.IsPassword = isPassword;
            return entry;
        }

        public static Entry IsTextPredictionEnabled(this Entry entry, bool enabled)
        {
            entry.IsTextPredictionEnabled = enabled;
            return entry;
        }

        public static Entry Placeholder(this Entry entry, string placeholder)
        {
            entry.Placeholder = placeholder;
            return entry;
        }

        public static Entry Placeholder(this Entry entry, string placeholder, Color textColor = default(Color))
        {
            entry.Placeholder = placeholder;
            entry.PlaceholderColor = textColor;
            return entry;
        }

        public static Entry PlaceholderColor(this Entry entry, Color color)
        {
            entry.PlaceholderColor = color;
            return entry;
        }

        public static Entry ReturnCommand(this Entry entry, ICommand command)
        {
            entry.ReturnCommand = command;
            return entry;
        }

        public static Entry ReturnCommand(this Entry entry, ICommand command, object parameter)
        {
            entry.ReturnCommand = command;
            entry.ReturnCommandParameter = parameter;
            return entry;
        }

        public static Entry ReturnCommandParameter(this Entry entry, object parameter)
        {
            entry.ReturnCommandParameter = parameter;
            return entry;
        }

        public static Entry ReturnType(this Entry entry, ReturnType returnType)
        {
            entry.ReturnType = returnType;
            return entry;
        }

        public static Entry SelectionLength(this Entry entry, int length)
        {
            entry.SelectionLength = length;
            return entry;
        }

        public static Entry Text(this Entry entry, string text)
        {
            entry.Text = text;
            return entry;
        }

        public static Entry Text(this Entry entry, string text, Color color)
        {
            entry.Text = text;
            entry.TextColor = color;
            return entry;
        }

        public static Entry TextColor(this Entry entry, Color textColor)
        {
            entry.TextColor = textColor;
            return entry;
        }
    }
}