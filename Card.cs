﻿using System;
using System.Windows.Forms;

namespace Lab3
{
	public abstract class ICard
	{
		public abstract void Connect();
		public abstract void Disconnect();
        public int BeginTransaction(float amount)
        {
            MessageBox.Show("Begin transaction 1 of " + amount + " EUR");
            return 1;
        }

        public bool EndTransaction(int id)
        {
            if (id != 1)
                return false;

            MessageBox.Show("End transaction 1");
            return true;
        }

        public void CancelTransaction(int id)
        {
            if (id != 1)
                throw new Exception("Incorrect transaction id");

            MessageBox.Show("Cancel transaction 1");
        }
    }

	// Mock CreditCard implementation
	public class CreditCard : ICard
	{
		public override void Connect ()
		{
			MessageBox.Show ("Connecting to credit card reader");
		}

		public override void Disconnect ()
		{
			MessageBox.Show ("Disconnecting from credit card reader");
		}
	}

	// Mock CreditCard implementation
	public class DebitCard : ICard
	{
		public override void Connect ()
		{
			MessageBox.Show ("Connecting to debit card reader");
		}

		public override void Disconnect ()
		{
			MessageBox.Show ("Disconnecting from debit card reader");
		}
	}
}

