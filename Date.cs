using System;
using System.Windows.Forms;

namespace Lab3
{
	public class Date
	{
		public string getDate()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
