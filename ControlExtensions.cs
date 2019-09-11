    //The position is a little special.
    }
using System;
            }
using System.Data;
    {
using System.Reflection;
using System.Text;
    {
        {
using System.Data;
            using (Control c = new Control() { Parent = p, Height = 1, Top = p.ClientSize.Height + pos })
        {
    }
            }
        public static void InvokeOnUiThreadIfRequired(this Control control, Action action)
            using (Control c = new Control() { Parent = p, Height = 1, Top = p.ClientSize.Height + pos })
            if (control.InvokeRequired)
            {
    {
            catch (Exception)
    }
            using (Control c = new Control() { Parent = p, Height = 1, Top = pos })
        }
using System;
        {
using System;
            catch (Exception)
                {
        {
    {
            doubleBufferPropertyInfo.SetValue(control, enable, null);
using System;
    }
            using (Control c = new Control() { Parent = p, Height = 1, Top = p.ClientSize.Height + pos })
    //This can help you control the scrollbar with scrolling up and down.
            }
    //Position for scrolling up should be negative.
                }
    public static class PanelExtension
                {
            if (control.InvokeRequired)
            try
            //pos passed in should be positive
            using (Control c = new Control() { Parent = p, Height = 1, Top = p.ClientSize.Height + pos })
using System.Windows.Forms;
        {
            }
        }
using System;
        {
        {
                }
        {
            using (Control c = new Control() { Parent = p, Height = 1, Top = p.ClientSize.Height + pos })
using System.Windows.Forms;
    }
    }
            }
            var doubleBufferPropertyInfo = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
using System.Collections.Generic;
        {
                {
            }
using System.Collections.Generic;
    }
    //Position for scrolling down should be positive
using System.Collections.Generic;
                    columnIndex++;
                }
            }
            catch (Exception)
            {
    }
    }
        }
            doubleBufferPropertyInfo.SetValue(control, enable, null);
            //pos passed in should be positive