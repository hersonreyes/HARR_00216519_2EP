using System;
using System.Windows.Forms;

namespace SourceCode
{
    public class EmptyTextBoxes: Exception
    {
        public EmptyTextBoxes(string message) : base(message)
        {
        }
    }
}