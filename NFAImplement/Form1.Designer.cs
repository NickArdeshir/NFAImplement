
namespace NFAImplement
{
    partial class Form1
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
            this.txtStateNames = new System.Windows.Forms.TextBox();
            this.txtAlphabet = new System.Windows.Forms.TextBox();
            this.lblStateName = new System.Windows.Forms.Label();
            this.lblAlaphabet = new System.Windows.Forms.Label();
            this.lblFinalStates = new System.Windows.Forms.Label();
            this.txtFinalStates = new System.Windows.Forms.TextBox();
            this.lblTransition = new System.Windows.Forms.Label();
            this.txtNumTransition = new System.Windows.Forms.TextBox();
            this.txtTransitions = new System.Windows.Forms.TextBox();
            this.lblTransitions = new System.Windows.Forms.Label();
            this.isAcceptedByNFA = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStateNames
            // 
            this.txtStateNames.Location = new System.Drawing.Point(90, 12);
            this.txtStateNames.Name = "txtStateNames";
            this.txtStateNames.Size = new System.Drawing.Size(120, 20);
            this.txtStateNames.TabIndex = 0;
            this.txtStateNames.Enter += new System.EventHandler(this.txtStateNames_Enter);
            this.txtStateNames.Leave += new System.EventHandler(this.txtStateNames_Leave);
            // 
            // txtAlphabet
            // 
            this.txtAlphabet.Location = new System.Drawing.Point(90, 38);
            this.txtAlphabet.Name = "txtAlphabet";
            this.txtAlphabet.Size = new System.Drawing.Size(120, 20);
            this.txtAlphabet.TabIndex = 1;
            this.txtAlphabet.Enter += new System.EventHandler(this.txtAlphabet_Enter);
            this.txtAlphabet.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.Location = new System.Drawing.Point(12, 15);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(72, 13);
            this.lblStateName.TabIndex = 2;
            this.lblStateName.Text = "State names :";
            // 
            // lblAlaphabet
            // 
            this.lblAlaphabet.AutoSize = true;
            this.lblAlaphabet.Location = new System.Drawing.Point(12, 41);
            this.lblAlaphabet.Name = "lblAlaphabet";
            this.lblAlaphabet.Size = new System.Drawing.Size(52, 13);
            this.lblAlaphabet.TabIndex = 3;
            this.lblAlaphabet.Text = "Alphabet:";
            // 
            // lblFinalStates
            // 
            this.lblFinalStates.AutoSize = true;
            this.lblFinalStates.Location = new System.Drawing.Point(12, 73);
            this.lblFinalStates.Name = "lblFinalStates";
            this.lblFinalStates.Size = new System.Drawing.Size(59, 13);
            this.lblFinalStates.TabIndex = 4;
            this.lblFinalStates.Text = "FinalStates";
            // 
            // txtFinalStates
            // 
            this.txtFinalStates.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFinalStates.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFinalStates.Location = new System.Drawing.Point(90, 70);
            this.txtFinalStates.Name = "txtFinalStates";
            this.txtFinalStates.Size = new System.Drawing.Size(120, 20);
            this.txtFinalStates.TabIndex = 2;
            this.txtFinalStates.Enter += new System.EventHandler(this.txtFinalStates_Enter);
            // 
            // lblTransition
            // 
            this.lblTransition.AutoSize = true;
            this.lblTransition.Location = new System.Drawing.Point(233, 15);
            this.lblTransition.Name = "lblTransition";
            this.lblTransition.Size = new System.Drawing.Size(110, 13);
            this.lblTransition.TabIndex = 6;
            this.lblTransition.Text = "Number of Transitions";
            // 
            // txtNumTransition
            // 
            this.txtNumTransition.Location = new System.Drawing.Point(349, 12);
            this.txtNumTransition.Name = "txtNumTransition";
            this.txtNumTransition.Size = new System.Drawing.Size(100, 20);
            this.txtNumTransition.TabIndex = 3;
            // 
            // txtTransitions
            // 
            this.txtTransitions.Location = new System.Drawing.Point(90, 105);
            this.txtTransitions.Multiline = true;
            this.txtTransitions.Name = "txtTransitions";
            this.txtTransitions.Size = new System.Drawing.Size(120, 138);
            this.txtTransitions.TabIndex = 4;
            // 
            // lblTransitions
            // 
            this.lblTransitions.AutoSize = true;
            this.lblTransitions.Location = new System.Drawing.Point(12, 108);
            this.lblTransitions.Name = "lblTransitions";
            this.lblTransitions.Size = new System.Drawing.Size(53, 13);
            this.lblTransitions.TabIndex = 9;
            this.lblTransitions.Text = "Transition";
            // 
            // isAcceptedByNFA
            // 
            this.isAcceptedByNFA.Location = new System.Drawing.Point(349, 213);
            this.isAcceptedByNFA.Name = "isAcceptedByNFA";
            this.isAcceptedByNFA.Size = new System.Drawing.Size(100, 30);
            this.isAcceptedByNFA.TabIndex = 6;
            this.isAcceptedByNFA.Text = "calculate";
            this.isAcceptedByNFA.UseVisualStyleBackColor = true;
            this.isAcceptedByNFA.Click += new System.EventHandler(this.isAcceptedByNFA_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(233, 55);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(61, 13);
            this.lblInput.TabIndex = 11;
            this.lblInput.Text = "Input String";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(349, 55);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 275);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.isAcceptedByNFA);
            this.Controls.Add(this.lblTransitions);
            this.Controls.Add(this.txtTransitions);
            this.Controls.Add(this.txtNumTransition);
            this.Controls.Add(this.lblTransition);
            this.Controls.Add(this.txtFinalStates);
            this.Controls.Add(this.lblFinalStates);
            this.Controls.Add(this.lblAlaphabet);
            this.Controls.Add(this.lblStateName);
            this.Controls.Add(this.txtAlphabet);
            this.Controls.Add(this.txtStateNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStateNames;
        private System.Windows.Forms.TextBox txtAlphabet;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.Label lblAlaphabet;
        private System.Windows.Forms.Label lblFinalStates;
        private System.Windows.Forms.TextBox txtFinalStates;
        private System.Windows.Forms.Label lblTransition;
        private System.Windows.Forms.TextBox txtNumTransition;
        private System.Windows.Forms.TextBox txtTransitions;
        private System.Windows.Forms.Label lblTransitions;
        private System.Windows.Forms.Button isAcceptedByNFA;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
    }
}

