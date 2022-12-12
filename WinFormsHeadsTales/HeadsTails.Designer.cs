namespace WinFormsHeadsTales
{
    partial class HeadsandTails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadsandTails));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTailsPoints = new System.Windows.Forms.Label();
            this.btnflipcoin = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblHeadsPoints = new System.Windows.Forms.Label();
            this.tblPic = new System.Windows.Forms.TableLayoutPanel();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerCoin = new System.Windows.Forms.Timer(this.components);
            this.tblMain.SuspendLayout();
            this.tblPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Ivory;
            this.imageList1.Images.SetKeyName(0, "heads.jpg");
            this.imageList1.Images.SetKeyName(1, "tails.jpg");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 195);
            this.button1.TabIndex = 0;
            this.button1.Text = "Flip Coin";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblTailsPoints, 1, 3);
            this.tblMain.Controls.Add(this.btnflipcoin, 0, 1);
            this.tblMain.Controls.Add(this.lblWinner, 0, 2);
            this.tblMain.Controls.Add(this.lblHeadsPoints, 0, 3);
            this.tblMain.Controls.Add(this.tblPic, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tblMain.Size = new System.Drawing.Size(998, 684);
            this.tblMain.TabIndex = 0;
            // 
            // lblTailsPoints
            // 
            this.lblTailsPoints.AutoSize = true;
            this.lblTailsPoints.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTailsPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTailsPoints.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTailsPoints.Location = new System.Drawing.Point(502, 584);
            this.lblTailsPoints.Name = "lblTailsPoints";
            this.lblTailsPoints.Size = new System.Drawing.Size(493, 100);
            this.lblTailsPoints.TabIndex = 4;
            this.lblTailsPoints.Text = "Tails = ";
            this.lblTailsPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnflipcoin
            // 
            this.btnflipcoin.BackColor = System.Drawing.Color.Yellow;
            this.tblMain.SetColumnSpan(this.btnflipcoin, 2);
            this.btnflipcoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnflipcoin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnflipcoin.Location = new System.Drawing.Point(3, 323);
            this.btnflipcoin.Name = "btnflipcoin";
            this.btnflipcoin.Size = new System.Drawing.Size(992, 159);
            this.btnflipcoin.TabIndex = 0;
            this.btnflipcoin.Text = "Click Here to Flip Coin";
            this.btnflipcoin.UseVisualStyleBackColor = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.White;
            this.tblMain.SetColumnSpan(this.lblWinner, 2);
            this.lblWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWinner.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWinner.Location = new System.Drawing.Point(3, 485);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(992, 99);
            this.lblWinner.TabIndex = 1;
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeadsPoints
            // 
            this.lblHeadsPoints.AutoSize = true;
            this.lblHeadsPoints.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeadsPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeadsPoints.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeadsPoints.Location = new System.Drawing.Point(3, 584);
            this.lblHeadsPoints.Name = "lblHeadsPoints";
            this.lblHeadsPoints.Size = new System.Drawing.Size(493, 100);
            this.lblHeadsPoints.TabIndex = 3;
            this.lblHeadsPoints.Text = "Heads = ";
            this.lblHeadsPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblPic
            // 
            this.tblPic.BackColor = System.Drawing.Color.White;
            this.tblPic.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblPic, 2);
            this.tblPic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tblPic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tblPic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tblPic.Controls.Add(this.picCoin, 1, 0);
            this.tblPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPic.Location = new System.Drawing.Point(3, 3);
            this.tblPic.Name = "tblPic";
            this.tblPic.RowCount = 1;
            this.tblPic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPic.Size = new System.Drawing.Size(992, 314);
            this.tblPic.TabIndex = 5;
            // 
            // picCoin
            // 
            this.picCoin.BackColor = System.Drawing.Color.Teal;
            this.picCoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCoin.Location = new System.Drawing.Point(338, 3);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(314, 308);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCoin.TabIndex = 6;
            this.picCoin.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // timerCoin
            // 
            this.timerCoin.Enabled = true;
            // 
            // HeadsandTails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 684);
            this.Controls.Add(this.tblMain);
            this.Name = "HeadsandTails";
            this.Text = "Heads and Tails Game";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblPic.ResumeLayout(false);
            this.tblPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList imageList1;
        private Button button1;
        private TableLayoutPanel tblMain;
        private Label lblTailsPoints;
        private Button btnflipcoin;
        private Label lblWinner;
        private Label lblHeadsPoints;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timerCoin;
        private TableLayoutPanel tblPic;
        private PictureBox picCoin;
    }
}