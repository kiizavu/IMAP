﻿
namespace IMAP
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlFolder = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTilte = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlContain = new System.Windows.Forms.Panel();
            this.lbAttachments = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.lbForm = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbSuject = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnInbox = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDrafts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStarred = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImportant = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTrash = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSpam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlFolder.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlFolder
            // 
            this.pnlFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pnlFolder.Controls.Add(this.btnTrash);
            this.pnlFolder.Controls.Add(this.btnSpam);
            this.pnlFolder.Controls.Add(this.btnStarred);
            this.pnlFolder.Controls.Add(this.btnImportant);
            this.pnlFolder.Controls.Add(this.btnDrafts);
            this.pnlFolder.Controls.Add(this.btnSent);
            this.pnlFolder.Controls.Add(this.bunifuFlatButton2);
            this.pnlFolder.Controls.Add(this.btnInbox);
            this.pnlFolder.Controls.Add(this.bunifuFlatButton1);
            this.pnlFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFolder.Location = new System.Drawing.Point(0, 0);
            this.pnlFolder.Name = "pnlFolder";
            this.pnlFolder.Size = new System.Drawing.Size(200, 940);
            this.pnlFolder.TabIndex = 1;
            this.pnlFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.pnlFolder.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.pnlFolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 75D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(63, 61);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(75, 75);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.bunifuSeparator3);
            this.panel2.Controls.Add(this.lbTilte);
            this.panel2.Controls.Add(this.pnlContainer);
            this.panel2.Location = new System.Drawing.Point(196, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 940);
            this.panel2.TabIndex = 1;
            // 
            // lbTilte
            // 
            this.lbTilte.AutoSize = true;
            this.lbTilte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.lbTilte.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTilte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTilte.Location = new System.Drawing.Point(10, 61);
            this.lbTilte.Name = "lbTilte";
            this.lbTilte.Size = new System.Drawing.Size(237, 90);
            this.lbTilte.TabIndex = 1;
            this.lbTilte.Text = "Inbox";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Location = new System.Drawing.Point(3, 223);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(584, 714);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlContain
            // 
            this.pnlContain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.pnlContain.Controls.Add(this.lbDate);
            this.pnlContain.Controls.Add(this.lbAttachments);
            this.pnlContain.Controls.Add(this.bunifuSeparator1);
            this.pnlContain.Controls.Add(this.rtbBody);
            this.pnlContain.Controls.Add(this.lbForm);
            this.pnlContain.Controls.Add(this.lbSuject);
            this.pnlContain.Location = new System.Drawing.Point(789, 3);
            this.pnlContain.Name = "pnlContain";
            this.pnlContain.Size = new System.Drawing.Size(811, 940);
            this.pnlContain.TabIndex = 2;
            // 
            // lbAttachments
            // 
            this.lbAttachments.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttachments.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbAttachments.Location = new System.Drawing.Point(38, 820);
            this.lbAttachments.Name = "lbAttachments";
            this.lbAttachments.Size = new System.Drawing.Size(745, 30);
            this.lbAttachments.TabIndex = 4;
            this.lbAttachments.Text = "Attachments";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(27, 773);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(767, 43);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // rtbBody
            // 
            this.rtbBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.rtbBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbBody.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBody.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtbBody.Location = new System.Drawing.Point(43, 263);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(736, 517);
            this.rtbBody.TabIndex = 2;
            this.rtbBody.Text = "Body";
            // 
            // lbForm
            // 
            this.lbForm.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbForm.Location = new System.Drawing.Point(38, 207);
            this.lbForm.Name = "lbForm";
            this.lbForm.Size = new System.Drawing.Size(745, 30);
            this.lbForm.TabIndex = 1;
            this.lbForm.Text = "From";
            // 
            // lbSuject
            // 
            this.lbSuject.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSuject.Location = new System.Drawing.Point(35, 48);
            this.lbSuject.Name = "lbSuject";
            this.lbSuject.Size = new System.Drawing.Size(748, 139);
            this.lbSuject.TabIndex = 0;
            this.lbSuject.Text = "Subject";
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.Red;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 25D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(1566, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.btnClose.OnHovercolor = System.Drawing.Color.Red;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Activecolor = System.Drawing.Color.Gray;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.ButtonText = "";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DisabledColor = System.Drawing.Color.Gray;
            this.btnMinimize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMinimize.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Iconimage")));
            this.btnMinimize.Iconimage_right = null;
            this.btnMinimize.Iconimage_right_Selected = null;
            this.btnMinimize.Iconimage_Selected = null;
            this.btnMinimize.IconMarginLeft = 0;
            this.btnMinimize.IconMarginRight = 0;
            this.btnMinimize.IconRightVisible = true;
            this.btnMinimize.IconRightZoom = 0D;
            this.btnMinimize.IconVisible = true;
            this.btnMinimize.IconZoom = 25D;
            this.btnMinimize.IsTab = false;
            this.btnMinimize.Location = new System.Drawing.Point(1538, 3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.btnMinimize.OnHovercolor = System.Drawing.Color.Gray;
            this.btnMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMinimize.selected = false;
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Textcolor = System.Drawing.Color.White;
            this.btnMinimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.DimGray;
            this.lbDate.Location = new System.Drawing.Point(674, 7);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(51, 23);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "Date";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(1, 940);
            this.bunifuSeparator3.TabIndex = 2;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // btnInbox
            // 
            this.btnInbox.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnInbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInbox.BorderRadius = 2;
            this.btnInbox.ButtonText = "INBOX";
            this.btnInbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInbox.DisabledColor = System.Drawing.Color.Gray;
            this.btnInbox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.ForeColor = System.Drawing.Color.White;
            this.btnInbox.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInbox.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInbox.Iconimage")));
            this.btnInbox.Iconimage_right = null;
            this.btnInbox.Iconimage_right_Selected = null;
            this.btnInbox.Iconimage_Selected = null;
            this.btnInbox.IconMarginLeft = 0;
            this.btnInbox.IconMarginRight = 0;
            this.btnInbox.IconRightVisible = true;
            this.btnInbox.IconRightZoom = 0D;
            this.btnInbox.IconVisible = true;
            this.btnInbox.IconZoom = 55D;
            this.btnInbox.IsTab = false;
            this.btnInbox.Location = new System.Drawing.Point(37, 236);
            this.btnInbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnInbox.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInbox.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInbox.selected = false;
            this.btnInbox.Size = new System.Drawing.Size(127, 40);
            this.btnInbox.TabIndex = 10;
            this.btnInbox.Text = "INBOX";
            this.btnInbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.Textcolor = System.Drawing.Color.White;
            this.btnInbox.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 2;
            this.bunifuFlatButton2.ButtonText = "All Mail";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 55D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(37, 293);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(127, 40);
            this.bunifuFlatButton2.TabIndex = 11;
            this.bunifuFlatButton2.Text = "All Mail";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDrafts
            // 
            this.btnDrafts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDrafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnDrafts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrafts.BorderRadius = 2;
            this.btnDrafts.ButtonText = "Drafts";
            this.btnDrafts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrafts.DisabledColor = System.Drawing.Color.Gray;
            this.btnDrafts.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrafts.ForeColor = System.Drawing.Color.White;
            this.btnDrafts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDrafts.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDrafts.Iconimage")));
            this.btnDrafts.Iconimage_right = null;
            this.btnDrafts.Iconimage_right_Selected = null;
            this.btnDrafts.Iconimage_Selected = null;
            this.btnDrafts.IconMarginLeft = 0;
            this.btnDrafts.IconMarginRight = 0;
            this.btnDrafts.IconRightVisible = true;
            this.btnDrafts.IconRightZoom = 0D;
            this.btnDrafts.IconVisible = true;
            this.btnDrafts.IconZoom = 55D;
            this.btnDrafts.IsTab = false;
            this.btnDrafts.Location = new System.Drawing.Point(37, 407);
            this.btnDrafts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDrafts.Name = "btnDrafts";
            this.btnDrafts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnDrafts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDrafts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDrafts.selected = false;
            this.btnDrafts.Size = new System.Drawing.Size(127, 40);
            this.btnDrafts.TabIndex = 13;
            this.btnDrafts.Text = "Drafts";
            this.btnDrafts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrafts.Textcolor = System.Drawing.Color.White;
            this.btnDrafts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSent
            // 
            this.btnSent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnSent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSent.BorderRadius = 2;
            this.btnSent.ButtonText = "Sent";
            this.btnSent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSent.DisabledColor = System.Drawing.Color.Gray;
            this.btnSent.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.ForeColor = System.Drawing.Color.White;
            this.btnSent.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSent.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSent.Iconimage")));
            this.btnSent.Iconimage_right = null;
            this.btnSent.Iconimage_right_Selected = null;
            this.btnSent.Iconimage_Selected = null;
            this.btnSent.IconMarginLeft = 0;
            this.btnSent.IconMarginRight = 0;
            this.btnSent.IconRightVisible = true;
            this.btnSent.IconRightZoom = 0D;
            this.btnSent.IconVisible = true;
            this.btnSent.IconZoom = 55D;
            this.btnSent.IsTab = false;
            this.btnSent.Location = new System.Drawing.Point(37, 350);
            this.btnSent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSent.Name = "btnSent";
            this.btnSent.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnSent.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSent.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSent.selected = false;
            this.btnSent.Size = new System.Drawing.Size(127, 40);
            this.btnSent.TabIndex = 12;
            this.btnSent.Text = "Sent";
            this.btnSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSent.Textcolor = System.Drawing.Color.White;
            this.btnSent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnStarred
            // 
            this.btnStarred.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStarred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnStarred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStarred.BorderRadius = 2;
            this.btnStarred.ButtonText = "Starred";
            this.btnStarred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStarred.DisabledColor = System.Drawing.Color.Gray;
            this.btnStarred.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarred.ForeColor = System.Drawing.Color.White;
            this.btnStarred.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStarred.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStarred.Iconimage")));
            this.btnStarred.Iconimage_right = null;
            this.btnStarred.Iconimage_right_Selected = null;
            this.btnStarred.Iconimage_Selected = null;
            this.btnStarred.IconMarginLeft = 0;
            this.btnStarred.IconMarginRight = 0;
            this.btnStarred.IconRightVisible = true;
            this.btnStarred.IconRightZoom = 0D;
            this.btnStarred.IconVisible = true;
            this.btnStarred.IconZoom = 55D;
            this.btnStarred.IsTab = false;
            this.btnStarred.Location = new System.Drawing.Point(37, 521);
            this.btnStarred.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStarred.Name = "btnStarred";
            this.btnStarred.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnStarred.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnStarred.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStarred.selected = false;
            this.btnStarred.Size = new System.Drawing.Size(127, 40);
            this.btnStarred.TabIndex = 15;
            this.btnStarred.Text = "Starred";
            this.btnStarred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStarred.Textcolor = System.Drawing.Color.White;
            this.btnStarred.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnImportant
            // 
            this.btnImportant.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnImportant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnImportant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportant.BorderRadius = 2;
            this.btnImportant.ButtonText = "Important";
            this.btnImportant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportant.DisabledColor = System.Drawing.Color.Gray;
            this.btnImportant.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportant.ForeColor = System.Drawing.Color.White;
            this.btnImportant.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImportant.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImportant.Iconimage")));
            this.btnImportant.Iconimage_right = null;
            this.btnImportant.Iconimage_right_Selected = null;
            this.btnImportant.Iconimage_Selected = null;
            this.btnImportant.IconMarginLeft = 0;
            this.btnImportant.IconMarginRight = 0;
            this.btnImportant.IconRightVisible = true;
            this.btnImportant.IconRightZoom = 0D;
            this.btnImportant.IconVisible = true;
            this.btnImportant.IconZoom = 55D;
            this.btnImportant.IsTab = false;
            this.btnImportant.Location = new System.Drawing.Point(37, 464);
            this.btnImportant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImportant.Name = "btnImportant";
            this.btnImportant.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnImportant.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnImportant.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImportant.selected = false;
            this.btnImportant.Size = new System.Drawing.Size(127, 40);
            this.btnImportant.TabIndex = 14;
            this.btnImportant.Text = "Important";
            this.btnImportant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportant.Textcolor = System.Drawing.Color.White;
            this.btnImportant.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnTrash
            // 
            this.btnTrash.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrash.BorderRadius = 2;
            this.btnTrash.ButtonText = "Trash";
            this.btnTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrash.DisabledColor = System.Drawing.Color.Gray;
            this.btnTrash.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrash.ForeColor = System.Drawing.Color.White;
            this.btnTrash.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTrash.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTrash.Iconimage")));
            this.btnTrash.Iconimage_right = null;
            this.btnTrash.Iconimage_right_Selected = null;
            this.btnTrash.Iconimage_Selected = null;
            this.btnTrash.IconMarginLeft = 0;
            this.btnTrash.IconMarginRight = 0;
            this.btnTrash.IconRightVisible = true;
            this.btnTrash.IconRightZoom = 0D;
            this.btnTrash.IconVisible = true;
            this.btnTrash.IconZoom = 55D;
            this.btnTrash.IsTab = false;
            this.btnTrash.Location = new System.Drawing.Point(37, 635);
            this.btnTrash.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnTrash.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTrash.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTrash.selected = false;
            this.btnTrash.Size = new System.Drawing.Size(127, 40);
            this.btnTrash.TabIndex = 17;
            this.btnTrash.Text = "Trash";
            this.btnTrash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrash.Textcolor = System.Drawing.Color.White;
            this.btnTrash.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSpam
            // 
            this.btnSpam.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSpam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnSpam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpam.BorderRadius = 2;
            this.btnSpam.ButtonText = "Spam";
            this.btnSpam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpam.DisabledColor = System.Drawing.Color.Gray;
            this.btnSpam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpam.ForeColor = System.Drawing.Color.White;
            this.btnSpam.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSpam.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSpam.Iconimage")));
            this.btnSpam.Iconimage_right = null;
            this.btnSpam.Iconimage_right_Selected = null;
            this.btnSpam.Iconimage_Selected = null;
            this.btnSpam.IconMarginLeft = 0;
            this.btnSpam.IconMarginRight = 0;
            this.btnSpam.IconRightVisible = true;
            this.btnSpam.IconRightZoom = 0D;
            this.btnSpam.IconVisible = true;
            this.btnSpam.IconZoom = 55D;
            this.btnSpam.IsTab = false;
            this.btnSpam.Location = new System.Drawing.Point(37, 578);
            this.btnSpam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSpam.Name = "btnSpam";
            this.btnSpam.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.btnSpam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSpam.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSpam.selected = false;
            this.btnSpam.Size = new System.Drawing.Size(127, 40);
            this.btnSpam.TabIndex = 16;
            this.btnSpam.Text = "Spam";
            this.btnSpam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpam.Textcolor = System.Drawing.Color.White;
            this.btnSpam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1600, 940);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlFolder);
            this.Controls.Add(this.pnlContain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlFolder.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlContain.ResumeLayout(false);
            this.pnlContain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlFolder;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnlContain;
        private System.Windows.Forms.Panel pnlContainer;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTilte;
        private Bunifu.Framework.UI.BunifuCustomLabel lbAttachments;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.RichTextBox rtbBody;
        private Bunifu.Framework.UI.BunifuCustomLabel lbForm;
        private Bunifu.Framework.UI.BunifuCustomLabel lbSuject;
        private Bunifu.Framework.UI.BunifuCustomLabel lbDate;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuFlatButton btnTrash;
        private Bunifu.Framework.UI.BunifuFlatButton btnSpam;
        private Bunifu.Framework.UI.BunifuFlatButton btnStarred;
        private Bunifu.Framework.UI.BunifuFlatButton btnImportant;
        private Bunifu.Framework.UI.BunifuFlatButton btnDrafts;
        private Bunifu.Framework.UI.BunifuFlatButton btnSent;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnInbox;
    }
}