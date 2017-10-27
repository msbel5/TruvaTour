namespace TruvaTour
{
    partial class Details
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
            this.lblTourNameText = new System.Windows.Forms.Label();
            this.lblTourDetailsText = new System.Windows.Forms.Label();
            this.lblTourName = new System.Windows.Forms.Label();
            this.lblTourDetails = new System.Windows.Forms.Label();
            this.lstvEvaluations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEvaluations = new System.Windows.Forms.Label();
            this.lblEvaluate = new System.Windows.Forms.Label();
            this.lblVote = new System.Windows.Forms.Label();
            this.grpbVote = new System.Windows.Forms.GroupBox();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.txtbComment = new System.Windows.Forms.TextBox();
            this.bttnEvaluate = new System.Windows.Forms.Button();
            this.lblAvgVoteText = new System.Windows.Forms.Label();
            this.lblAvgVote = new System.Windows.Forms.Label();
            this.bttnBack = new System.Windows.Forms.Button();
            this.grpbVote.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTourNameText
            // 
            this.lblTourNameText.AutoSize = true;
            this.lblTourNameText.Location = new System.Drawing.Point(57, 35);
            this.lblTourNameText.Name = "lblTourNameText";
            this.lblTourNameText.Size = new System.Drawing.Size(44, 13);
            this.lblTourNameText.TabIndex = 0;
            this.lblTourNameText.Text = "Tur Adı:";
            // 
            // lblTourDetailsText
            // 
            this.lblTourDetailsText.AutoSize = true;
            this.lblTourDetailsText.Location = new System.Drawing.Point(31, 66);
            this.lblTourDetailsText.Name = "lblTourDetailsText";
            this.lblTourDetailsText.Size = new System.Drawing.Size(70, 13);
            this.lblTourDetailsText.TabIndex = 0;
            this.lblTourDetailsText.Text = "Tur Detayları:";
            // 
            // lblTourName
            // 
            this.lblTourName.AutoSize = true;
            this.lblTourName.Location = new System.Drawing.Point(107, 35);
            this.lblTourName.Name = "lblTourName";
            this.lblTourName.Size = new System.Drawing.Size(44, 13);
            this.lblTourName.TabIndex = 0;
            this.lblTourName.Text = "Tur Adı:";
            // 
            // lblTourDetails
            // 
            this.lblTourDetails.AutoSize = true;
            this.lblTourDetails.Location = new System.Drawing.Point(107, 66);
            this.lblTourDetails.Name = "lblTourDetails";
            this.lblTourDetails.Size = new System.Drawing.Size(70, 13);
            this.lblTourDetails.TabIndex = 0;
            this.lblTourDetails.Text = "Tur Detayları:";
            // 
            // lstvEvaluations
            // 
            this.lstvEvaluations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvEvaluations.GridLines = true;
            this.lstvEvaluations.Location = new System.Drawing.Point(110, 105);
            this.lstvEvaluations.Name = "lstvEvaluations";
            this.lstvEvaluations.Size = new System.Drawing.Size(784, 171);
            this.lstvEvaluations.TabIndex = 1;
            this.lstvEvaluations.UseCompatibleStateImageBehavior = false;
            this.lstvEvaluations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Değerlendiren Kişi";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Puan";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yorum";
            this.columnHeader3.Width = 569;
            // 
            // lblEvaluations
            // 
            this.lblEvaluations.AutoSize = true;
            this.lblEvaluations.Location = new System.Drawing.Point(12, 105);
            this.lblEvaluations.Name = "lblEvaluations";
            this.lblEvaluations.Size = new System.Drawing.Size(89, 13);
            this.lblEvaluations.TabIndex = 0;
            this.lblEvaluations.Text = "Değerlendirmeler:";
            // 
            // lblEvaluate
            // 
            this.lblEvaluate.AutoSize = true;
            this.lblEvaluate.Location = new System.Drawing.Point(10, 347);
            this.lblEvaluate.Name = "lblEvaluate";
            this.lblEvaluate.Size = new System.Drawing.Size(91, 13);
            this.lblEvaluate.TabIndex = 0;
            this.lblEvaluate.Text = "Değerlendirmeniz:";
            // 
            // lblVote
            // 
            this.lblVote.AutoSize = true;
            this.lblVote.Location = new System.Drawing.Point(51, 302);
            this.lblVote.Name = "lblVote";
            this.lblVote.Size = new System.Drawing.Size(50, 13);
            this.lblVote.TabIndex = 3;
            this.lblVote.Text = "Puanınız:";
            // 
            // grpbVote
            // 
            this.grpbVote.Controls.Add(this.rdb5);
            this.grpbVote.Controls.Add(this.rdb4);
            this.grpbVote.Controls.Add(this.rdb3);
            this.grpbVote.Controls.Add(this.rdb2);
            this.grpbVote.Controls.Add(this.rdb1);
            this.grpbVote.Location = new System.Drawing.Point(110, 291);
            this.grpbVote.Name = "grpbVote";
            this.grpbVote.Size = new System.Drawing.Size(215, 40);
            this.grpbVote.TabIndex = 2;
            this.grpbVote.TabStop = false;
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(166, 11);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(31, 17);
            this.rdb5.TabIndex = 0;
            this.rdb5.TabStop = true;
            this.rdb5.Text = "5";
            this.rdb5.UseVisualStyleBackColor = true;
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(129, 11);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(31, 17);
            this.rdb4.TabIndex = 0;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "4";
            this.rdb4.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(92, 11);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(31, 17);
            this.rdb3.TabIndex = 0;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "3";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(55, 11);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(31, 17);
            this.rdb2.TabIndex = 0;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "2";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(18, 11);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(31, 17);
            this.rdb1.TabIndex = 0;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "1";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // txtbComment
            // 
            this.txtbComment.Location = new System.Drawing.Point(110, 347);
            this.txtbComment.MaxLength = 500;
            this.txtbComment.Multiline = true;
            this.txtbComment.Name = "txtbComment";
            this.txtbComment.Size = new System.Drawing.Size(784, 109);
            this.txtbComment.TabIndex = 4;
            // 
            // bttnEvaluate
            // 
            this.bttnEvaluate.Location = new System.Drawing.Point(545, 299);
            this.bttnEvaluate.Name = "bttnEvaluate";
            this.bttnEvaluate.Size = new System.Drawing.Size(174, 23);
            this.bttnEvaluate.TabIndex = 5;
            this.bttnEvaluate.Text = "Gönder";
            this.bttnEvaluate.UseVisualStyleBackColor = true;
            this.bttnEvaluate.Click += new System.EventHandler(this.bttnEvaluate_Click);
            // 
            // lblAvgVoteText
            // 
            this.lblAvgVoteText.AutoSize = true;
            this.lblAvgVoteText.Location = new System.Drawing.Point(358, 302);
            this.lblAvgVoteText.Name = "lblAvgVoteText";
            this.lblAvgVoteText.Size = new System.Drawing.Size(80, 13);
            this.lblAvgVoteText.TabIndex = 3;
            this.lblAvgVoteText.Text = "Ortalama Puan:";
            // 
            // lblAvgVote
            // 
            this.lblAvgVote.AutoSize = true;
            this.lblAvgVote.Location = new System.Drawing.Point(444, 302);
            this.lblAvgVote.Name = "lblAvgVote";
            this.lblAvgVote.Size = new System.Drawing.Size(77, 13);
            this.lblAvgVote.TabIndex = 3;
            this.lblAvgVote.Text = "Ortalama Puan";
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(737, 299);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(157, 23);
            this.bttnBack.TabIndex = 6;
            this.bttnBack.Text = "Geri Dön";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 506);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.bttnEvaluate);
            this.Controls.Add(this.txtbComment);
            this.Controls.Add(this.lblAvgVote);
            this.Controls.Add(this.lblAvgVoteText);
            this.Controls.Add(this.lblVote);
            this.Controls.Add(this.grpbVote);
            this.Controls.Add(this.lstvEvaluations);
            this.Controls.Add(this.lblTourDetails);
            this.Controls.Add(this.lblEvaluate);
            this.Controls.Add(this.lblEvaluations);
            this.Controls.Add(this.lblTourDetailsText);
            this.Controls.Add(this.lblTourName);
            this.Controls.Add(this.lblTourNameText);
            this.Name = "Details";
            this.Text = "Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Details_FormClosed);
            this.Load += new System.EventHandler(this.Details_Load);
            this.grpbVote.ResumeLayout(false);
            this.grpbVote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTourNameText;
        private System.Windows.Forms.Label lblTourDetailsText;
        private System.Windows.Forms.Label lblTourName;
        private System.Windows.Forms.Label lblTourDetails;
        private System.Windows.Forms.ListView lstvEvaluations;
        private System.Windows.Forms.Label lblEvaluations;
        private System.Windows.Forms.Label lblEvaluate;
        private System.Windows.Forms.Label lblVote;
        private System.Windows.Forms.GroupBox grpbVote;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.TextBox txtbComment;
        private System.Windows.Forms.Button bttnEvaluate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblAvgVoteText;
        private System.Windows.Forms.Label lblAvgVote;
        private System.Windows.Forms.Button bttnBack;
    }
}