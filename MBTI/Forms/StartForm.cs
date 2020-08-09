using MBTI.Data;
using MBTI.Forms;

namespace MBTI
{
    public partial class StartForm : DevExpress.XtraEditors.XtraForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            
            User user = DataRepository.User.Get(txeName.Text, txeMail.Text);
            if(user == null)
            {
                user = new User();
                user.Name = txeName.Text;
                user.Email = txeMail.Text;
                DataRepository.User.Insert(user);
            }

            TestForm testForm = new TestForm(user.UserId);
            testForm.ShowDialog();

            Close();

        }
    }
}