using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Lesson9
{
    /**
     *<summary>
     * This is default constructor for login class 
     * </summary>
     * 
     * @Constructor LoginForm
     */
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Private Methods+++++++++++++++++++++++++++++++++

            /**
             * <summary>
             * This method clears username and password textbox
             * </summary>
             * 
             * @private 
             * @ method _clearForm
             * return {void}
             */

            private void _clearForm()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
        }

        /**
         * <summary>
         * this is LoginButton Click event handler
         * </summary>
         * 
         * @Private
         * @method LoginButton_Click
         * @param {object} sender
         * @param {EventArgs} e
         * @return {void}
         */
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Username: " + UsernameTextBox.Text);
            Debug.WriteLine("Password: " + PasswordTextBox.Text);
            this._clearForm();  
        }
    }
}
