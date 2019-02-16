            {
    }
using System;
using System.Collections.Generic;
using System.Data;
    {
using System.Reflection;
using System.Text;
    {
        {
namespace PCKLIB
            {
        {
        public static void DoubleBuffered(this Control control, bool enable)
            }
        public static void InvokeOnUiThreadIfRequired(this Control control, Action action)
        {
            if (control.InvokeRequired)
            {
    {
            doubleBufferPropertyInfo.SetValue(control, enable, null);
            doubleBufferPropertyInfo.SetValue(control, enable, null);
            using (Control c = new Control() { Parent = p, Height = 1, Top = pos })
        }
            }
            using (Control c = new Control() { Parent = p, Height = 1, Top = pos })
using System;
            catch (Exception)
                {
        {
    {
            doubleBufferPropertyInfo.SetValue(control, enable, null);
        }
    }
            using (Control c = new Control() { Parent = p, Height = 1, Top = p.ClientSize.Height + pos })
    //This can help you control the scrollbar with scrolling up and down.
            }
    //Position for scrolling up should be negative.
    //Position for scrolling down should be positive
    public static class PanelExtension
    {
        public static void ScrollDown(this Panel p, int pos)
        {
            //pos passed in should be positive
            using (Control c = new Control() { Parent = p, Height = 1, Top = p.ClientSize.Height + pos })
using System.Windows.Forms;
            {
            }
        }
        public static void ScrollUp(this Panel p, int pos)
        {
            //pos passed in should be negative
                }
            {
    }
using System.Windows.Forms;
    //The position is a little special.
    }
            }
            var doubleBufferPropertyInfo = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
using System.Collections.Generic;
        {
            try
            }
                int columnIndex = 0;
                foreach (var columnName in columnNames)
                {
                    table.Columns[columnName].SetOrdinal(columnIndex);
                    columnIndex++;
                }
            }
            catch (Exception)
            {

        {
        }
    }
namespace PCKLIB