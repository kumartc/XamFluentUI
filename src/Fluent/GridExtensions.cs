﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class GridExtensions
    {
        public static Grid RowsAndColumns(this Grid grid, int rows = 1, int columns = 1)
        {
            if (rows > 1)
                grid = AddRows(grid, rows);

            if (columns > 1)
                grid = AddColumns(grid, columns);

            return grid;
        }

        public static Grid AddRows(this Grid grid, int rows = 0)
        {
            if (rows < 1)
                return grid;

            for (var i = 0; i < rows; i++)
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

            return grid;
        }

        public static Grid AddColumns(this Grid grid, int columns = 0)
        {
            if (columns < 1)
                return grid;

            for (var i = 0; i < columns; i++)
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

            return grid;
        }

        public static Grid ConfigureColumn(this Grid grid, int column, GridLength length)
        {
            grid.ColumnDefinitions[column].Width = length;
            return grid;
        }

        public static Grid ConfigureColumns(this Grid grid, params Tuple<int, GridLength>[] values)
        {
            values.ForEach(x => grid.ColumnDefinitions[x.Item1].Width = x.Item2);
            return grid;
        }

        public static Grid ConfigureRow(this Grid grid, int row, GridLength length)
        {
            grid.RowDefinitions[row].Height = length;
            return grid;
        }

        public static Grid ConfigureRows(this Grid grid, params Tuple<int, GridLength>[] values)
        {
            values.ForEach(x => grid.RowDefinitions[x.Item1].Height = x.Item2);
            return grid;
        }

        public static Grid RowAndColumnSpacing(this Grid grid, double rowSpacing = 0, double columnSpacing = 0)
        {
            grid.RowSpacing = 0;
            grid.ColumnSpacing = 0;
            return grid;
        }
    }
}