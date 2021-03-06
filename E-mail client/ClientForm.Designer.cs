﻿namespace E_mail_client
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelFolders = new System.Windows.Forms.Panel();
            this.lnkArchive = new System.Windows.Forms.LinkLabel();
            this.lnkAll = new System.Windows.Forms.LinkLabel();
            this.lnkTrash = new System.Windows.Forms.LinkLabel();
            this.lnkJunk = new System.Windows.Forms.LinkLabel();
            this.lnkFlagged = new System.Windows.Forms.LinkLabel();
            this.lnkImportant = new System.Windows.Forms.LinkLabel();
            this.lnkDrafts = new System.Windows.Forms.LinkLabel();
            this.lnkSent = new System.Windows.Forms.LinkLabel();
            this.lnkInbox = new System.Windows.Forms.LinkLabel();
            this.gbViewMessages = new System.Windows.Forms.GroupBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.labelAttachments = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.gbMessagesAndButton = new System.Windows.Forms.GroupBox();
            this.picDownload = new System.Windows.Forms.PictureBox();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnMoveMessage = new System.Windows.Forms.Button();
            this.btnDeleteMessage = new System.Windows.Forms.Button();
            this.btnNewMessage = new System.Windows.Forms.Button();
            this.tableLayoutPanelNameEmail = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameEmail = new System.Windows.Forms.Label();
            this.gbMenu.SuspendLayout();
            this.panelFolders.SuspendLayout();
            this.gbViewMessages.SuspendLayout();
            this.gbMessagesAndButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.panelButton.SuspendLayout();
            this.tableLayoutPanelNameEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.treeViewFolder);
            this.gbMenu.Controls.Add(this.panel3);
            this.gbMenu.Controls.Add(this.panel1);
            this.gbMenu.Controls.Add(this.panel2);
            this.gbMenu.Controls.Add(this.panelFolders);
            this.gbMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMenu.Location = new System.Drawing.Point(0, 40);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(200, 463);
            this.gbMenu.TabIndex = 2;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Папки";
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewFolder.FullRowSelect = true;
            this.treeViewFolder.ItemHeight = 18;
            this.treeViewFolder.Location = new System.Drawing.Point(3, 293);
            this.treeViewFolder.Name = "treeViewFolder";
            this.treeViewFolder.Size = new System.Drawing.Size(194, 167);
            this.treeViewFolder.TabIndex = 9;
            this.treeViewFolder.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewFolder_BeforeSelect);
            this.treeViewFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewFolder_AfterSelect);
            this.treeViewFolder.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewFolder_NodeMouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 10);
            this.panel3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 10);
            this.panel2.TabIndex = 10;
            // 
            // panelFolders
            // 
            this.panelFolders.Controls.Add(this.lnkArchive);
            this.panelFolders.Controls.Add(this.lnkAll);
            this.panelFolders.Controls.Add(this.lnkTrash);
            this.panelFolders.Controls.Add(this.lnkJunk);
            this.panelFolders.Controls.Add(this.lnkFlagged);
            this.panelFolders.Controls.Add(this.lnkImportant);
            this.panelFolders.Controls.Add(this.lnkDrafts);
            this.panelFolders.Controls.Add(this.lnkSent);
            this.panelFolders.Controls.Add(this.lnkInbox);
            this.panelFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFolders.Location = new System.Drawing.Point(3, 25);
            this.panelFolders.Name = "panelFolders";
            this.panelFolders.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panelFolders.Size = new System.Drawing.Size(194, 247);
            this.panelFolders.TabIndex = 8;
            // 
            // lnkArchive
            // 
            this.lnkArchive.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkArchive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkArchive.Image = global::E_mail_client.Properties.Resources.archive;
            this.lnkArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkArchive.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkArchive.Location = new System.Drawing.Point(8, 216);
            this.lnkArchive.Name = "lnkArchive";
            this.lnkArchive.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkArchive.Size = new System.Drawing.Size(186, 27);
            this.lnkArchive.TabIndex = 8;
            this.lnkArchive.TabStop = true;
            this.lnkArchive.Text = "Архив";
            this.lnkArchive.Visible = false;
            this.lnkArchive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkAll
            // 
            this.lnkAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkAll.Image = global::E_mail_client.Properties.Resources.mails;
            this.lnkAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkAll.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkAll.Location = new System.Drawing.Point(8, 189);
            this.lnkAll.Name = "lnkAll";
            this.lnkAll.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkAll.Size = new System.Drawing.Size(186, 27);
            this.lnkAll.TabIndex = 7;
            this.lnkAll.TabStop = true;
            this.lnkAll.Text = "Вся почта";
            this.lnkAll.Visible = false;
            this.lnkAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkTrash
            // 
            this.lnkTrash.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkTrash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkTrash.Image = global::E_mail_client.Properties.Resources.empty_trash;
            this.lnkTrash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkTrash.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkTrash.Location = new System.Drawing.Point(8, 162);
            this.lnkTrash.Name = "lnkTrash";
            this.lnkTrash.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkTrash.Size = new System.Drawing.Size(186, 27);
            this.lnkTrash.TabIndex = 6;
            this.lnkTrash.TabStop = true;
            this.lnkTrash.Text = "Корзина";
            this.lnkTrash.Visible = false;
            this.lnkTrash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkJunk
            // 
            this.lnkJunk.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkJunk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkJunk.Image = global::E_mail_client.Properties.Resources.junk;
            this.lnkJunk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkJunk.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkJunk.Location = new System.Drawing.Point(8, 135);
            this.lnkJunk.Name = "lnkJunk";
            this.lnkJunk.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkJunk.Size = new System.Drawing.Size(186, 27);
            this.lnkJunk.TabIndex = 5;
            this.lnkJunk.TabStop = true;
            this.lnkJunk.Text = "Спам";
            this.lnkJunk.Visible = false;
            this.lnkJunk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkFlagged
            // 
            this.lnkFlagged.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkFlagged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkFlagged.Image = global::E_mail_client.Properties.Resources.flag;
            this.lnkFlagged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkFlagged.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkFlagged.Location = new System.Drawing.Point(8, 108);
            this.lnkFlagged.Name = "lnkFlagged";
            this.lnkFlagged.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkFlagged.Size = new System.Drawing.Size(186, 27);
            this.lnkFlagged.TabIndex = 4;
            this.lnkFlagged.TabStop = true;
            this.lnkFlagged.Text = "Помеченные";
            this.lnkFlagged.Visible = false;
            this.lnkFlagged.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkImportant
            // 
            this.lnkImportant.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkImportant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkImportant.Image = global::E_mail_client.Properties.Resources.important;
            this.lnkImportant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkImportant.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkImportant.Location = new System.Drawing.Point(8, 81);
            this.lnkImportant.Name = "lnkImportant";
            this.lnkImportant.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkImportant.Size = new System.Drawing.Size(186, 27);
            this.lnkImportant.TabIndex = 3;
            this.lnkImportant.TabStop = true;
            this.lnkImportant.Text = "Важное";
            this.lnkImportant.Visible = false;
            this.lnkImportant.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkDrafts
            // 
            this.lnkDrafts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkDrafts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkDrafts.Image = global::E_mail_client.Properties.Resources.pencil;
            this.lnkDrafts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkDrafts.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkDrafts.Location = new System.Drawing.Point(8, 54);
            this.lnkDrafts.Name = "lnkDrafts";
            this.lnkDrafts.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkDrafts.Size = new System.Drawing.Size(186, 27);
            this.lnkDrafts.TabIndex = 2;
            this.lnkDrafts.TabStop = true;
            this.lnkDrafts.Text = "Черновики";
            this.lnkDrafts.Visible = false;
            this.lnkDrafts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkSent
            // 
            this.lnkSent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkSent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkSent.Image = global::E_mail_client.Properties.Resources.paper_plane;
            this.lnkSent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkSent.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkSent.Location = new System.Drawing.Point(8, 27);
            this.lnkSent.Name = "lnkSent";
            this.lnkSent.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkSent.Size = new System.Drawing.Size(186, 27);
            this.lnkSent.TabIndex = 1;
            this.lnkSent.TabStop = true;
            this.lnkSent.Text = "Отправленные";
            this.lnkSent.Visible = false;
            this.lnkSent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lnkInbox
            // 
            this.lnkInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkInbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkInbox.Image = global::E_mail_client.Properties.Resources.inbox;
            this.lnkInbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkInbox.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkInbox.Location = new System.Drawing.Point(8, 0);
            this.lnkInbox.Name = "lnkInbox";
            this.lnkInbox.Padding = new System.Windows.Forms.Padding(24, 4, 5, 6);
            this.lnkInbox.Size = new System.Drawing.Size(186, 27);
            this.lnkInbox.TabIndex = 0;
            this.lnkInbox.TabStop = true;
            this.lnkInbox.Text = "Входящие";
            this.lnkInbox.Visible = false;
            this.lnkInbox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // gbViewMessages
            // 
            this.gbViewMessages.BackColor = System.Drawing.SystemColors.Control;
            this.gbViewMessages.Controls.Add(this.webBrowser);
            this.gbViewMessages.Controls.Add(this.labelAttachments);
            this.gbViewMessages.Controls.Add(this.panel4);
            this.gbViewMessages.Controls.Add(this.panel5);
            this.gbViewMessages.Controls.Add(this.panel6);
            this.gbViewMessages.Controls.Add(this.labelTo);
            this.gbViewMessages.Controls.Add(this.labelFrom);
            this.gbViewMessages.Controls.Add(this.labelTheme);
            this.gbViewMessages.Controls.Add(this.labelDate);
            this.gbViewMessages.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbViewMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbViewMessages.Location = new System.Drawing.Point(716, 40);
            this.gbViewMessages.Name = "gbViewMessages";
            this.gbViewMessages.Size = new System.Drawing.Size(372, 463);
            this.gbViewMessages.TabIndex = 4;
            this.gbViewMessages.TabStop = false;
            this.gbViewMessages.Text = "Просмотр";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(3, 148);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(366, 312);
            this.webBrowser.TabIndex = 16;
            // 
            // labelAttachments
            // 
            this.labelAttachments.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttachments.Image = ((System.Drawing.Image)(resources.GetObject("labelAttachments.Image")));
            this.labelAttachments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAttachments.LinkColor = System.Drawing.Color.Green;
            this.labelAttachments.Location = new System.Drawing.Point(3, 148);
            this.labelAttachments.Name = "labelAttachments";
            this.labelAttachments.Padding = new System.Windows.Forms.Padding(30, 0, 0, 5);
            this.labelAttachments.Size = new System.Drawing.Size(366, 0);
            this.labelAttachments.TabIndex = 15;
            this.labelAttachments.TabStop = true;
            this.labelAttachments.Text = "Скачать вложения";
            this.labelAttachments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAttachments.Visible = false;
            this.labelAttachments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelAttachments_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 10);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 1);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 127);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(366, 10);
            this.panel6.TabIndex = 13;
            // 
            // labelTo
            // 
            this.labelTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.Location = new System.Drawing.Point(3, 100);
            this.labelTo.Name = "labelTo";
            this.labelTo.Padding = new System.Windows.Forms.Padding(5);
            this.labelTo.Size = new System.Drawing.Size(366, 27);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "Кому: ";
            this.labelTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFrom
            // 
            this.labelFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(3, 73);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Padding = new System.Windows.Forms.Padding(5);
            this.labelFrom.Size = new System.Drawing.Size(366, 27);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "От: ";
            this.labelFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTheme
            // 
            this.labelTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTheme.Location = new System.Drawing.Point(3, 46);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Padding = new System.Windows.Forms.Padding(5);
            this.labelTheme.Size = new System.Drawing.Size(366, 27);
            this.labelTheme.TabIndex = 1;
            this.labelTheme.Text = "Тема: ";
            this.labelTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(3, 19);
            this.labelDate.Name = "labelDate";
            this.labelDate.Padding = new System.Windows.Forms.Padding(5);
            this.labelDate.Size = new System.Drawing.Size(366, 27);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Дата: ";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 40);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 463);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(713, 40);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 463);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // gbMessagesAndButton
            // 
            this.gbMessagesAndButton.Controls.Add(this.picDownload);
            this.gbMessagesAndButton.Controls.Add(this.dgvMessages);
            this.gbMessagesAndButton.Controls.Add(this.panelButton);
            this.gbMessagesAndButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMessagesAndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMessagesAndButton.Location = new System.Drawing.Point(203, 40);
            this.gbMessagesAndButton.Name = "gbMessagesAndButton";
            this.gbMessagesAndButton.Size = new System.Drawing.Size(510, 463);
            this.gbMessagesAndButton.TabIndex = 7;
            this.gbMessagesAndButton.TabStop = false;
            this.gbMessagesAndButton.Text = "Письма";
            // 
            // picDownload
            // 
            this.picDownload.BackColor = System.Drawing.Color.White;
            this.picDownload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDownload.ErrorImage = null;
            this.picDownload.Image = global::E_mail_client.Properties.Resources.download;
            this.picDownload.Location = new System.Drawing.Point(3, 19);
            this.picDownload.Name = "picDownload";
            this.picDownload.Size = new System.Drawing.Size(504, 399);
            this.picDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDownload.TabIndex = 4;
            this.picDownload.TabStop = false;
            this.picDownload.Visible = false;
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.AllowUserToResizeRows = false;
            this.dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessages.BackgroundColor = System.Drawing.Color.White;
            this.dgvMessages.ColumnHeadersHeight = 30;
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessages.Location = new System.Drawing.Point(3, 19);
            this.dgvMessages.MultiSelect = false;
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.RowHeadersVisible = false;
            this.dgvMessages.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessages.Size = new System.Drawing.Size(504, 399);
            this.dgvMessages.TabIndex = 3;
            this.dgvMessages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMessages_CellClick);
            this.dgvMessages.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMessages_RowEnter);
            this.dgvMessages.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMessages_RowLeave);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnMoveMessage);
            this.panelButton.Controls.Add(this.btnDeleteMessage);
            this.panelButton.Controls.Add(this.btnNewMessage);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelButton.Location = new System.Drawing.Point(3, 418);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(504, 42);
            this.panelButton.TabIndex = 2;
            // 
            // btnMoveMessage
            // 
            this.btnMoveMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMoveMessage.Enabled = false;
            this.btnMoveMessage.Image = global::E_mail_client.Properties.Resources.move_message;
            this.btnMoveMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoveMessage.Location = new System.Drawing.Point(332, 6);
            this.btnMoveMessage.Name = "btnMoveMessage";
            this.btnMoveMessage.Size = new System.Drawing.Size(159, 30);
            this.btnMoveMessage.TabIndex = 2;
            this.btnMoveMessage.Text = "Переместить сообщение";
            this.btnMoveMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoveMessage.UseVisualStyleBackColor = true;
            this.btnMoveMessage.Click += new System.EventHandler(this.BtnMoveMessage_Click);
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteMessage.Enabled = false;
            this.btnDeleteMessage.Image = global::E_mail_client.Properties.Resources.delete_message;
            this.btnDeleteMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMessage.Location = new System.Drawing.Point(191, 6);
            this.btnDeleteMessage.Name = "btnDeleteMessage";
            this.btnDeleteMessage.Size = new System.Drawing.Size(135, 30);
            this.btnDeleteMessage.TabIndex = 1;
            this.btnDeleteMessage.Text = "Удалить сообщение";
            this.btnDeleteMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteMessage.UseVisualStyleBackColor = true;
            this.btnDeleteMessage.Click += new System.EventHandler(this.ButtonDeleteMessage_Click);
            // 
            // btnNewMessage
            // 
            this.btnNewMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewMessage.Image = global::E_mail_client.Properties.Resources.new_message;
            this.btnNewMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMessage.Location = new System.Drawing.Point(6, 6);
            this.btnNewMessage.Name = "btnNewMessage";
            this.btnNewMessage.Size = new System.Drawing.Size(179, 30);
            this.btnNewMessage.TabIndex = 0;
            this.btnNewMessage.Text = "Написать новое сообщение";
            this.btnNewMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewMessage.UseVisualStyleBackColor = true;
            this.btnNewMessage.Click += new System.EventHandler(this.ButtonNewMessage_Click);
            // 
            // tableLayoutPanelNameEmail
            // 
            this.tableLayoutPanelNameEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelNameEmail.ColumnCount = 1;
            this.tableLayoutPanelNameEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNameEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNameEmail.Controls.Add(this.labelNameEmail, 0, 0);
            this.tableLayoutPanelNameEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelNameEmail.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelNameEmail.Name = "tableLayoutPanelNameEmail";
            this.tableLayoutPanelNameEmail.RowCount = 1;
            this.tableLayoutPanelNameEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNameEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelNameEmail.Size = new System.Drawing.Size(1088, 40);
            this.tableLayoutPanelNameEmail.TabIndex = 0;
            // 
            // labelNameEmail
            // 
            this.labelNameEmail.AutoSize = true;
            this.labelNameEmail.BackColor = System.Drawing.SystemColors.Window;
            this.labelNameEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNameEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameEmail.ForeColor = System.Drawing.Color.Green;
            this.labelNameEmail.Location = new System.Drawing.Point(3, 3);
            this.labelNameEmail.Margin = new System.Windows.Forms.Padding(3);
            this.labelNameEmail.Name = "labelNameEmail";
            this.labelNameEmail.Size = new System.Drawing.Size(1082, 34);
            this.labelNameEmail.TabIndex = 0;
            this.labelNameEmail.Text = "email address";
            this.labelNameEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 503);
            this.Controls.Add(this.gbMessagesAndButton);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gbViewMessages);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.tableLayoutPanelNameEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-mail Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.gbMenu.ResumeLayout(false);
            this.panelFolders.ResumeLayout(false);
            this.gbViewMessages.ResumeLayout(false);
            this.gbMessagesAndButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.tableLayoutPanelNameEmail.ResumeLayout(false);
            this.tableLayoutPanelNameEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.GroupBox gbViewMessages;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox gbMessagesAndButton;
        private System.Windows.Forms.Panel panelFolders;
        private System.Windows.Forms.LinkLabel lnkArchive;
        private System.Windows.Forms.LinkLabel lnkAll;
        private System.Windows.Forms.LinkLabel lnkTrash;
        private System.Windows.Forms.LinkLabel lnkJunk;
        private System.Windows.Forms.LinkLabel lnkFlagged;
        private System.Windows.Forms.LinkLabel lnkImportant;
        private System.Windows.Forms.LinkLabel lnkDrafts;
        private System.Windows.Forms.LinkLabel lnkSent;
        private System.Windows.Forms.LinkLabel lnkInbox;
        private System.Windows.Forms.TreeView treeViewFolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNameEmail;
        private System.Windows.Forms.Label labelNameEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnDeleteMessage;
        private System.Windows.Forms.Button btnNewMessage;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.LinkLabel labelAttachments;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.PictureBox picDownload;
        private System.Windows.Forms.Button btnMoveMessage;
    }
}