﻿using System.Windows.Forms;

namespace Application_Development_Project
{
    partial class MainPageForm
    {
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


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

        private void properClose()
        {
            this.FormClosing += MainForm_FormClosing;
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.mainFormTabPage = new System.Windows.Forms.TabPage();
            this.viewAllGymMemberTab = new System.Windows.Forms.TabPage();
            this.SecurityTabPage = new System.Windows.Forms.TabPage();
            this.errorLabel = new System.Windows.Forms.Label();
            this.ChangeAttemptsLabel = new System.Windows.Forms.Button();
            this.attemtsTextBox = new System.Windows.Forms.TextBox();
            this.AttemptsLabel = new System.Windows.Forms.Label();
            this.resetErrorLabel = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldPassLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.createGymMemberButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.agreeCheckBox = new System.Windows.Forms.CheckBox();
            this.tosLabel = new System.Windows.Forms.Label();
            this.creditCardTextBox = new System.Windows.Forms.TextBox();
            this.creditCardNumber = new System.Windows.Forms.Label();
            this.removeScreenButton = new System.Windows.Forms.Button();
            this.gymMemberCreateDetails = new System.Windows.Forms.Label();
            this.gymMemberListTextBox = new System.Windows.Forms.TextBox();
            this.MainTabControl.SuspendLayout();
            this.mainFormTabPage.SuspendLayout();
            this.viewAllGymMemberTab.SuspendLayout();
            this.SecurityTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.mainFormTabPage);
            this.MainTabControl.Controls.Add(this.viewAllGymMemberTab);
            this.MainTabControl.Controls.Add(this.SecurityTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(700, 496);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.Click += new System.EventHandler(this.viewAllGymMemberTab_Click);
            // 
            // mainFormTabPage
            // 
            this.mainFormTabPage.Controls.Add(this.gymMemberCreateDetails);
            this.mainFormTabPage.Controls.Add(this.removeScreenButton);
            this.mainFormTabPage.Controls.Add(this.creditCardTextBox);
            this.mainFormTabPage.Controls.Add(this.creditCardNumber);
            this.mainFormTabPage.Controls.Add(this.tosLabel);
            this.mainFormTabPage.Controls.Add(this.agreeCheckBox);
            this.mainFormTabPage.Controls.Add(this.addressTextBox);
            this.mainFormTabPage.Controls.Add(this.addressLabel);
            this.mainFormTabPage.Controls.Add(this.emailAddressTextBox);
            this.mainFormTabPage.Controls.Add(this.emailAddressLabel);
            this.mainFormTabPage.Controls.Add(this.phoneNumberTextBox);
            this.mainFormTabPage.Controls.Add(this.phoneNumberLabel);
            this.mainFormTabPage.Controls.Add(this.nameTextBox);
            this.mainFormTabPage.Controls.Add(this.nameLabel);
            this.mainFormTabPage.Controls.Add(this.createGymMemberButton);
            this.mainFormTabPage.Location = new System.Drawing.Point(4, 25);
            this.mainFormTabPage.Name = "mainFormTabPage";
            this.mainFormTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainFormTabPage.Size = new System.Drawing.Size(692, 467);
            this.mainFormTabPage.TabIndex = 0;
            this.mainFormTabPage.Text = "Create Gym Member";
            this.mainFormTabPage.UseVisualStyleBackColor = true;
            // 
            // viewAllGymMemberTab
            // 
            this.viewAllGymMemberTab.Controls.Add(this.gymMemberListTextBox);
            this.viewAllGymMemberTab.Location = new System.Drawing.Point(4, 25);
            this.viewAllGymMemberTab.Name = "viewAllGymMemberTab";
            this.viewAllGymMemberTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewAllGymMemberTab.Size = new System.Drawing.Size(692, 467);
            this.viewAllGymMemberTab.TabIndex = 1;
            this.viewAllGymMemberTab.Text = "Gym Members";
            this.viewAllGymMemberTab.UseVisualStyleBackColor = true;
            // 
            // SecurityTabPage
            // 
            this.SecurityTabPage.Controls.Add(this.errorLabel);
            this.SecurityTabPage.Controls.Add(this.ChangeAttemptsLabel);
            this.SecurityTabPage.Controls.Add(this.attemtsTextBox);
            this.SecurityTabPage.Controls.Add(this.AttemptsLabel);
            this.SecurityTabPage.Controls.Add(this.resetErrorLabel);
            this.SecurityTabPage.Controls.Add(this.oldPasswordTextBox);
            this.SecurityTabPage.Controls.Add(this.oldPassLabel);
            this.SecurityTabPage.Controls.Add(this.changePasswordButton);
            this.SecurityTabPage.Controls.Add(this.instructionLabel);
            this.SecurityTabPage.Controls.Add(this.newPasswordTextBox);
            this.SecurityTabPage.Controls.Add(this.newPassLabel);
            this.SecurityTabPage.Location = new System.Drawing.Point(4, 25);
            this.SecurityTabPage.Name = "SecurityTabPage";
            this.SecurityTabPage.Size = new System.Drawing.Size(877, 471);
            this.SecurityTabPage.TabIndex = 2;
            this.SecurityTabPage.Text = "System Security";
            this.SecurityTabPage.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(206, 179);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(415, 28);
            this.errorLabel.TabIndex = 24;
            // 
            // ChangeAttemptsLabel
            // 
            this.ChangeAttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeAttemptsLabel.Location = new System.Drawing.Point(56, 144);
            this.ChangeAttemptsLabel.Name = "ChangeAttemptsLabel";
            this.ChangeAttemptsLabel.Size = new System.Drawing.Size(129, 63);
            this.ChangeAttemptsLabel.TabIndex = 23;
            this.ChangeAttemptsLabel.Text = "Change Attempts";
            this.ChangeAttemptsLabel.UseVisualStyleBackColor = true;
            this.ChangeAttemptsLabel.Click += new System.EventHandler(this.ChangeAttemptsLabel_Click);
            // 
            // attemtsTextBox
            // 
            this.attemtsTextBox.Location = new System.Drawing.Point(211, 113);
            this.attemtsTextBox.Name = "attemtsTextBox";
            this.attemtsTextBox.Size = new System.Drawing.Size(353, 22);
            this.attemtsTextBox.TabIndex = 21;
            // 
            // AttemptsLabel
            // 
            this.AttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemptsLabel.Location = new System.Drawing.Point(8, 82);
            this.AttemptsLabel.Name = "AttemptsLabel";
            this.AttemptsLabel.Size = new System.Drawing.Size(197, 59);
            this.AttemptsLabel.TabIndex = 20;
            this.AttemptsLabel.Text = "New Allowed Number of Attempts: ";
            // 
            // resetErrorLabel
            // 
            this.resetErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetErrorLabel.Location = new System.Drawing.Point(206, 393);
            this.resetErrorLabel.Name = "resetErrorLabel";
            this.resetErrorLabel.Size = new System.Drawing.Size(415, 28);
            this.resetErrorLabel.TabIndex = 19;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(211, 289);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(353, 22);
            this.oldPasswordTextBox.TabIndex = 18;
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassLabel.Location = new System.Drawing.Point(49, 289);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(165, 28);
            this.oldPassLabel.TabIndex = 17;
            this.oldPassLabel.Text = "Old Password: ";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.Location = new System.Drawing.Point(56, 358);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(129, 63);
            this.changePasswordButton.TabIndex = 16;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(206, 355);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(458, 28);
            this.instructionLabel.TabIndex = 15;
            this.instructionLabel.Text = "New System password will be aplied on next start up";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(211, 327);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(353, 22);
            this.newPasswordTextBox.TabIndex = 14;
            // 
            // newPassLabel
            // 
            this.newPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.Location = new System.Drawing.Point(49, 327);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(165, 28);
            this.newPassLabel.TabIndex = 13;
            this.newPassLabel.Text = "New Password: ";
            // 
            // createGymMemberButton
            // 
            this.createGymMemberButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createGymMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGymMemberButton.Location = new System.Drawing.Point(6, 386);
            this.createGymMemberButton.Name = "createGymMemberButton";
            this.createGymMemberButton.Size = new System.Drawing.Size(192, 75);
            this.createGymMemberButton.TabIndex = 0;
            this.createGymMemberButton.Text = "Create Gym Member";
            this.createGymMemberButton.UseVisualStyleBackColor = true;
            this.createGymMemberButton.Click += new System.EventHandler(this.createGymMemberButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(13, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 22);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(17, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(161, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(17, 91);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(161, 22);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(13, 66);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(135, 22);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailAddressTextBox.Location = new System.Drawing.Point(17, 150);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(161, 22);
            this.emailAddressTextBox.TabIndex = 6;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(13, 125);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(130, 22);
            this.emailAddressLabel.TabIndex = 5;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.Location = new System.Drawing.Point(17, 206);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(161, 66);
            this.addressTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(13, 181);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(81, 22);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address:";
            // 
            // agreeCheckBox
            // 
            this.agreeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agreeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreeCheckBox.Location = new System.Drawing.Point(8, 328);
            this.agreeCheckBox.Name = "agreeCheckBox";
            this.agreeCheckBox.Size = new System.Drawing.Size(183, 52);
            this.agreeCheckBox.TabIndex = 9;
            this.agreeCheckBox.Text = "I Agree To terms Of Srevice ";
            this.agreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // tosLabel
            // 
            this.tosLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosLabel.Location = new System.Drawing.Point(197, 32);
            this.tosLabel.Name = "tosLabel";
            this.tosLabel.Size = new System.Drawing.Size(455, 312);
            this.tosLabel.TabIndex = 10;
            this.tosLabel.Text = resources.GetString("tosLabel.Text");
            // 
            // creditCardTextBox
            // 
            this.creditCardTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creditCardTextBox.Location = new System.Drawing.Point(17, 300);
            this.creditCardTextBox.Name = "creditCardTextBox";
            this.creditCardTextBox.Size = new System.Drawing.Size(161, 22);
            this.creditCardTextBox.TabIndex = 12;
            // 
            // creditCardNumber
            // 
            this.creditCardNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creditCardNumber.AutoSize = true;
            this.creditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardNumber.Location = new System.Drawing.Point(13, 275);
            this.creditCardNumber.Name = "creditCardNumber";
            this.creditCardNumber.Size = new System.Drawing.Size(175, 22);
            this.creditCardNumber.TabIndex = 11;
            this.creditCardNumber.Text = "Credit Card Number:";
            // 
            // removeScreenButton
            // 
            this.removeScreenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeScreenButton.Location = new System.Drawing.Point(627, 409);
            this.removeScreenButton.Name = "removeScreenButton";
            this.removeScreenButton.Size = new System.Drawing.Size(62, 52);
            this.removeScreenButton.TabIndex = 13;
            this.removeScreenButton.Text = "Ok";
            this.removeScreenButton.UseVisualStyleBackColor = true;
            this.removeScreenButton.Click += new System.EventHandler(this.removeScreenButton_Click);
            // 
            // gymMemberCreateDetails
            // 
            this.gymMemberCreateDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gymMemberCreateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymMemberCreateDetails.Location = new System.Drawing.Point(204, 354);
            this.gymMemberCreateDetails.Name = "gymMemberCreateDetails";
            this.gymMemberCreateDetails.Size = new System.Drawing.Size(417, 107);
            this.gymMemberCreateDetails.TabIndex = 14;
            // 
            // gymMemberListTextBox
            // 
            this.gymMemberListTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gymMemberListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymMemberListTextBox.Location = new System.Drawing.Point(3, 3);
            this.gymMemberListTextBox.Multiline = true;
            this.gymMemberListTextBox.Name = "gymMemberListTextBox";
            this.gymMemberListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gymMemberListTextBox.Size = new System.Drawing.Size(686, 461);
            this.gymMemberListTextBox.TabIndex = 0;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 496);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainPageForm";
            this.Text = "Gym System Main Page ";
            this.MainTabControl.ResumeLayout(false);
            this.mainFormTabPage.ResumeLayout(false);
            this.mainFormTabPage.PerformLayout();
            this.viewAllGymMemberTab.ResumeLayout(false);
            this.viewAllGymMemberTab.PerformLayout();
            this.SecurityTabPage.ResumeLayout(false);
            this.SecurityTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTabControl;
        private TabPage mainFormTabPage;
        private TabPage viewAllGymMemberTab;
        private TabPage SecurityTabPage;
        private TextBox oldPasswordTextBox;
        private Label oldPassLabel;
        private Button changePasswordButton;
        private Label instructionLabel;
        private TextBox newPasswordTextBox;
        private Label newPassLabel;
        private Label resetErrorLabel;
        private Label errorLabel;
        private Button ChangeAttemptsLabel;
        private TextBox attemtsTextBox;
        private Label AttemptsLabel;
        private Label nameLabel;
        private Button createGymMemberButton;
        private TextBox nameTextBox;
        private TextBox emailAddressTextBox;
        private Label emailAddressLabel;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private TextBox addressTextBox;
        private Label addressLabel;
        private CheckBox agreeCheckBox;
        private TextBox creditCardTextBox;
        private Label creditCardNumber;
        private Label tosLabel;
        private Label gymMemberCreateDetails;
        private Button removeScreenButton;
        private TextBox gymMemberListTextBox;
    }
}