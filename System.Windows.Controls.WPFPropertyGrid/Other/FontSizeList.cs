﻿using System.Collections.ObjectModel;

namespace System.Windows.Controls.WpfPropertyGrid
{
  public class FontSizeList : ObservableCollection<double>
  {
    public FontSizeList()
    {
      Add(8);
      Add(9);
      Add(10);
      Add(11);
      Add(12);
      Add(14);
      Add(16);
      Add(18);
      Add(20);
    }
  }
}
