using System;
using System.Windows.Forms;
///using System.Windows.Controls;
///using System.Windows.Input;
using NoChangeParking.Core;
using NoChangeParking.FitFixtures;
using System.Collections.Generic;

namespace NoChangeParking.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button6 = new System.Windows.Forms.Button();
        	this.button5 = new System.Windows.Forms.Button();
        	this.button4 = new System.Windows.Forms.Button();
        	this.button9 = new System.Windows.Forms.Button();
        	this.button8 = new System.Windows.Forms.Button();
        	this.button7 = new System.Windows.Forms.Button();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.button10 = new System.Windows.Forms.Button();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.groupBox3 = new System.Windows.Forms.GroupBox();
        	this.groupBox4 = new System.Windows.Forms.GroupBox();
        	this.menuStrip1.SuspendLayout();
        	this.groupBox1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	this.groupBox3.SuspendLayout();
        	this.groupBox4.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(565, 24);
        	this.menuStrip1.TabIndex = 0;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.aboutToolStripMenuItem.Text = "&About";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(413, 15);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(116, 23);
        	this.button3.TabIndex = 2;
        	this.button3.Text = "Does it know me";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SystemCheck3ClickEvent);
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(223, 15);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(119, 23);
        	this.button2.TabIndex = 1;
        	this.button2.Text = "Is it the right system";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SystemCheck2ClickEvent);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(26, 15);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(113, 23);
        	this.button1.TabIndex = 0;
        	this.button1.Text = "Is System There";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SystemCheck1ClickEvent);
        	// 
        	// button6
        	// 
        	this.button6.Location = new System.Drawing.Point(352, 13);
        	this.button6.Name = "button6";
        	this.button6.Size = new System.Drawing.Size(177, 23);
        	this.button6.TabIndex = 2;
        	this.button6.Text = "Park different vehicle to registered";
        	this.button6.UseVisualStyleBackColor = true;
        	this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PayForParkButton3Click);
        	// 
        	// button5
        	// 
        	this.button5.Location = new System.Drawing.Point(223, 13);
        	this.button5.Name = "button5";
        	this.button5.Size = new System.Drawing.Size(119, 23);
        	this.button5.TabIndex = 1;
        	this.button5.Text = "Registered Parking";
        	this.button5.UseVisualStyleBackColor = true;
        	this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PayForParkButton2Click);
        	// 
        	// button4
        	// 
        	this.button4.Location = new System.Drawing.Point(26, 13);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(125, 23);
        	this.button4.TabIndex = 0;
        	this.button4.Text = "Unregistered Parking";
        	this.button4.UseVisualStyleBackColor = true;
        	this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PayForParkButton1ClickEvent);
        	// 
        	// button9
        	// 
        	this.button9.Location = new System.Drawing.Point(352, 17);
        	this.button9.Name = "button9";
        	this.button9.Size = new System.Drawing.Size(177, 23);
        	this.button9.TabIndex = 2;
        	this.button9.Text = "Registered Vehicle list";
        	this.button9.UseVisualStyleBackColor = true;
        	this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ParkingInspectorButton3Click);
        	// 
        	// button8
        	// 
        	this.button8.Location = new System.Drawing.Point(223, 17);
        	this.button8.Name = "button8";
        	this.button8.Size = new System.Drawing.Size(119, 23);
        	this.button8.TabIndex = 1;
        	this.button8.Text = "Check if Vehicle Paid";
        	this.button8.UseVisualStyleBackColor = true;
        	this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ParkingInspectorButton2Click);
        	// 
        	// button7
        	// 
        	this.button7.Location = new System.Drawing.Point(26, 17);
        	this.button7.Name = "button7";
        	this.button7.Size = new System.Drawing.Size(113, 23);
        	this.button7.TabIndex = 0;
        	this.button7.Text = "Inspector Vehicle list check";
        	this.button7.UseVisualStyleBackColor = true;
        	this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ParkingInspectorButton1ClickEvent);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.button10);
        	this.groupBox1.Location = new System.Drawing.Point(12, 187);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(541, 55);
        	this.groupBox1.TabIndex = 4;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Register Defaults";
        	// 
        	// button10
        	// 
        	this.button10.Location = new System.Drawing.Point(26, 19);
        	this.button10.Name = "button10";
        	this.button10.Size = new System.Drawing.Size(141, 23);
        	this.button10.TabIndex = 0;
        	this.button10.Text = "Register Default Details";
        	this.button10.UseVisualStyleBackColor = true;
        	this.button10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegisterDefaultDetailsButton1Click);
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.button4);
        	this.groupBox2.Controls.Add(this.button6);
        	this.groupBox2.Controls.Add(this.button5);
        	this.groupBox2.Location = new System.Drawing.Point(12, 87);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(541, 42);
        	this.groupBox2.TabIndex = 5;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Pay for Parking";
        	// 
        	// groupBox3
        	// 
        	this.groupBox3.Controls.Add(this.button7);
        	this.groupBox3.Controls.Add(this.button9);
        	this.groupBox3.Controls.Add(this.button8);
        	this.groupBox3.Location = new System.Drawing.Point(12, 135);
        	this.groupBox3.Name = "groupBox3";
        	this.groupBox3.Size = new System.Drawing.Size(541, 46);
        	this.groupBox3.TabIndex = 6;
        	this.groupBox3.TabStop = false;
        	this.groupBox3.Text = "Parking Inspector Functions";
        	// 
        	// groupBox4
        	// 
        	this.groupBox4.Controls.Add(this.button1);
        	this.groupBox4.Controls.Add(this.button3);
        	this.groupBox4.Controls.Add(this.button2);
        	this.groupBox4.Location = new System.Drawing.Point(12, 37);
        	this.groupBox4.Name = "groupBox4";
        	this.groupBox4.Size = new System.Drawing.Size(541, 44);
        	this.groupBox4.TabIndex = 7;
        	this.groupBox4.TabStop = false;
        	this.groupBox4.Text = "Check System";
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(565, 246);
        	this.Controls.Add(this.groupBox4);
        	this.Controls.Add(this.groupBox3);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.menuStrip1);
        	this.MainMenuStrip = this.menuStrip1;
        	this.Name = "MainForm";
        	this.Load += new System.EventHandler(this.MainForm_Load);
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox3.ResumeLayout(false);
        	this.groupBox4.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        
        public static int answer;
      	public static string appName;
      	public static string retName;
      	public static string aVehicle;
      	public static string aCreditCardNo;
      	public static CallCentre cc = CallCentre.Instance;
        public static Voucher retPayment;
		PaymentsList plist = cc.TodaysPayments;
		public static string tField;
		
		ICollection<Driver> dl1 = cc.RegisteredDrivers;
		private static string aName;
		
		
      	
        void SystemCheck1ClickEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
       		CheckAddition chaf = new CheckAddition();
  			chaf.lhs = 1;
        	chaf.rhs = 7;
        	answer = chaf.result();
        	this.button1.Text = "OK - " + chaf.lhs + " + " + chaf.rhs + " = " + answer;
        }
        
        void SystemCheck2ClickEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
        	CheckApplication chan = new CheckApplication(); 
        	string appName = chan.Name();
        	this.button2.Text = appName;
        }
        
        void SystemCheck3ClickEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
        	CheckSayHello cshf = new CheckSayHello();
        	
        	// Instantiate the dialog box
		    Button3Dialog dlg = new Button3Dialog();
		    // Configure the dialog box
    		dlg.Owner = this;
    		dlg.Margin = this.Margin;
		    // Open the dialog box modally 
    		if (dlg.ShowDialog() == DialogResult.OK )
		    	{
				cshf.name = dlg.textBox1.Text;
				retName = cshf.sayHello();
    			this.button3.Text = retName;
    			}
        }
        
        void PayForParkButton1ClickEvent(object sender, MouseEventArgs e)
        {
			DriverCall dc = cc.NewCallFromDriver("Driver Name");
		    
			PayForParkDialog1 pfp1 = new PayForParkDialog1();
		    pfp1.Owner = this;
    		pfp1.Margin = this.Margin;
			if (pfp1.ShowDialog() == DialogResult.OK )
		    	{
				aVehicle = pfp1.textBox1.Text;
				}	
			PayForParkDialog2 pfp2 = new PayForParkDialog2();
		    pfp2.Owner = this;
    		pfp2.Margin = this.Margin;
			if (pfp2.ShowDialog() == DialogResult.OK )
		    	{
				aCreditCardNo = pfp2.textBox1.Text;
				}
			retPayment = dc.PayForVehicleWithCreditCard(aVehicle, aCreditCardNo);
			if (retPayment is NoChangeParking.Core.Voucher){
				MessageBox.Show(aVehicle + " Successfully paid for parking");
 				}
        	else{
				MessageBox.Show("not accepted, this vehicle has already paid");
        		}
        }
        
        void ParkingInspectorButton1ClickEvent(object sender, MouseEventArgs e)
        {
        	InspectorListVehicleControl1 ilvc1 = new InspectorListVehicleControl1();
        	ilvc1.Show();
			
			foreach (Payment paymentInList in plist)
			{
				tField = paymentInList.PaidForVehicle;
				ilvc1.textBox1.Text += (tField + "\r\n");
			}
		}
        
        void RegisterDefaultDetailsButton1Click(object sender, MouseEventArgs e)
        {
        	RegDefaultDtlsDialog1 rdd1 = new RegDefaultDtlsDialog1();
		    rdd1.Owner = this;
    		rdd1.Margin = this.Margin;
			if (rdd1.ShowDialog() == DialogResult.OK )
		    	{
				aName = rdd1.textBox1.Text;
				}	
        	RegDefaultDtlsDialog2 rdd2 = new RegDefaultDtlsDialog2();
		    rdd2.Owner = this;
    		rdd2.Margin = this.Margin;
			if (rdd2.ShowDialog() == DialogResult.OK )
		    	{
				aVehicle = rdd2.textBox1.Text;
				}	
			RegDefaultDtlsDialog3 rdd3 = new RegDefaultDtlsDialog3();
		    rdd3.Owner = this;
    		rdd3.Margin = this.Margin;
			if (rdd3.ShowDialog() == DialogResult.OK )
		    	{
				aCreditCardNo = rdd3.textBox1.Text;
				}

			DriverCall dc = cc.NewCallFromDriver(aName);
			///Driver d1 = dc.getDriver();
			Boolean ret1 = dc.RegisterVehicle(aVehicle);
			dc.RegisterCreditCard(aCreditCardNo);
			///dl1.add(d1);
			
			if (ret1 == true){
				MessageBox.Show(aName + " details successfully registered");
			}
			else{
				MessageBox.Show(aName + " not registered");
			}
        }
        
        void ParkingInspectorButton3Click(object sender, MouseEventArgs e)
        {
        	RegVehicleListControl1 rvlc1 = new RegVehicleListControl1();
        	rvlc1.Show();
			tField = ("Driver, Vehicle, Credit Card No");
			tField += ("\r\n-------------------------------");
			rvlc1.textBox1.Text += (tField + "\r\n");
			foreach (Driver driverInList in dl1)
			{
				tField = driverInList.Id;
				tField += (", " + driverInList.DefaultVehicle);
				tField += (", " + driverInList.DefaultCreditCard);
				rvlc1.textBox1.Text += (tField + "\r\n");
			}
        }
        
        void ParkingInspectorButton2Click(object sender, MouseEventArgs e)
        {
        	ChkVehPaidDialog1 cvp1 = new ChkVehPaidDialog1();
		    cvp1.Owner = this;
    		cvp1.Margin = this.Margin;
			if (cvp1.ShowDialog() == DialogResult.OK )
		    	{
				aVehicle = cvp1.textBox1.Text;
				}	
			
			if (cc.VehicleHasPaid(aVehicle)){
				MessageBox.Show(aVehicle+" has paid");
			}
			else{
				MessageBox.Show("Vehicle has not Paid");
			}
        }
        
        void PayForParkButton2Click(object sender, MouseEventArgs e)
        {
        	RegDefaultDtlsDialog1 rdd1 = new RegDefaultDtlsDialog1();
		    rdd1.Owner = this;
    		rdd1.Margin = this.Margin;
			if (rdd1.ShowDialog() == DialogResult.OK )
		    	{
				aName = rdd1.textBox1.Text;
				}	

			DriverCall dc = cc.NewCallFromDriver(aName);
			
            DialogResult dlgr = MessageBox.Show("Use your default Car Registration - " + dc.Vehicle ,
		    				"Registered Parking",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);
            if (dlgr == DialogResult.Yes)
	            {
    	    	retPayment = dc.PayForVehicleWithCreditCard(dc.Vehicle, dc.CreditCard);
				if (retPayment is NoChangeParking.Core.Voucher){
					MessageBox.Show(aVehicle + " Successfully paid for parking");
	 				}	
        		else{
					MessageBox.Show("not accepted, this vehicle has already paid");
    	    		}
            	}        
        }
        
        void PayForParkButton3Click(object sender, MouseEventArgs e)
        {
          	RegDefaultDtlsDialog1 rdd1 = new RegDefaultDtlsDialog1();
		    rdd1.Owner = this;
    		rdd1.Margin = this.Margin;
			if (rdd1.ShowDialog() == DialogResult.OK )
		    	{
				aName = rdd1.textBox1.Text;
				}	

			DriverCall dc = cc.NewCallFromDriver(aName);      	

			DialogResult dlgr = MessageBox.Show("Your default Car Registration is - " + dc.Vehicle + 
			                "\nDo you want to enter details of unregistered vehicle" ,
		    				"Registered Parking -Different Vehicle",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Information);
            if (dlgr == DialogResult.Yes)
	            {
				PayForParkDialog1 pfp1 = new PayForParkDialog1();
		    	pfp1.Owner = this;
    			pfp1.Margin = this.Margin;
				if (pfp1.ShowDialog() == DialogResult.OK )
		    		{
					aVehicle = pfp1.textBox1.Text;
					}	
				PayForParkDialog2 pfp2 = new PayForParkDialog2();
		    	pfp2.Owner = this;
    			pfp2.Margin = this.Margin;
				if (pfp2.ShowDialog() == DialogResult.OK )
		    		{
					aCreditCardNo = pfp2.textBox1.Text;
					}
            	retPayment = dc.PayForVehicleWithCreditCard(aVehicle, aCreditCardNo);
				if (retPayment is NoChangeParking.Core.Voucher){
					MessageBox.Show(aVehicle + " Successfully paid for parking");
	 				}	
        		else{
					MessageBox.Show("not accepted, this vehicle has already paid");
    	    		}
            	}        
        }
	}	
}

	        ///MessageBox.Show(dlg.textBox1 + " was entered into the database");