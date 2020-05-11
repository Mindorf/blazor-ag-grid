using System;

namespace BlazorAgGrid
{
    /// <summary>
    /// Strongly-typed counterpart of:
    ///    https://www.ag-grid.com/javascript-grid-events/
    /// </summary>
    public partial class GridEvents
    {
        public Action<RowNode[]> SelectionChanged { set => Set(value); }
        public Action<object> CellEditingStopped {set => Set(value); }
    }
}
