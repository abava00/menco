//https://qiita.com/LemonLeaf/items/4c5e957df4d39ddc911b

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace project
{
  /// <summary>
  /// GameWindow.xaml の相互作用ロジック
  /// </summary>
  public partial class GameWindow : Window
  {
    public GameWindow()
    {
      InitializeComponent();
    }

    private bool _isMouseDown;
    private Point _startPoint;
    private Point _currentPoint;

    private void OperationArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      _isMouseDown = true;
      _startPoint = e.GetPosition(OperationArea);
      e.Handled = true;

    }

    private void OperationArea_MouseLeftButtonUp(object sender, MouseEventArgs e)
    {
      _isMouseDown = false;
      e.Handled = true;
    }


    private void OperationArea_MouseMove(object sender, MouseEventArgs e)
    {
      if (!_isMouseDown)
      {
        return;
      }

      _currentPoint = e.GetPosition(OperationArea);

      double offsetX = _currentPoint.X - _startPoint.X;
      double offsetY = _currentPoint.Y - _startPoint.Y;

      Matrix matrix = ((MatrixTransform)Target.RenderTransform).Matrix;

      matrix.Translate(offsetX, offsetY);
      Target.RenderTransform = new MatrixTransform(matrix);


      _startPoint = _currentPoint;
      e.Handled = true;

    }
    private void OperationArea_MouseLeave(object sender, MouseEventArgs e)
    {
      _isMouseDown = false;

      e.Handled = true;
    }

    int your_turn = 0;
    int my_turn = 1;
    int or = 0;
    private void Button_Click(object sender, RoutedEventArgs e)
    {
      or++;
      if(or%2 == 0)
      {
        my_turn++;
        MyTurn.Content = "Now Turn" + my_turn;
      }
      else
      {
        your_turn ++;
        YourTurn.Content = "Now Turn" + your_turn;
      }


    }
  }
}
