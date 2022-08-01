using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copy_MemoryAddress
{
    public partial class Form1 : Form
    {
        cCopySample cOrg;

        public Form1()
        {
            InitializeComponent();
        }

        // 원본 데이터 Btn
        private void btnOrigin_Click(object sender, EventArgs e)
        {
            cOrg = new cCopySample();

            cOrg.iCopy = int.Parse(tboxInt.Text);   //(int) X
            cOrg.charCopy = char.Parse(tboxChar.Text);

            cOrg.arrCopy = new int[] { int.Parse(tboxIntArray.Text) ,0,0,0,0};
            cOrg.claCopy.iValue = int.Parse(tboxClassNumber.Text);

            lblOriginData.Text = $"{cOrg.iCopy}, {cOrg.charCopy}, [{string.Join(",",cOrg.arrCopy)}], {cOrg.claCopy.iValue}";
        }


        // 복사 Btn
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (rdoEqual.Checked)
            {
                gbox.Text = "a = b";
                fEqual();
            }
            else if (rdoSallowCopy.Checked)
            {
                gbox.Text = "Shallow Copy";
                fShallowCopy();
            }
            else if (rdoDeepCopy.Checked)
            {
                gbox.Text = "Deep Copy";
                fDeepCopy();
            }
        }


        // 여기서 만들어준 Origin. class cCopySample에..
        private void fEqual()
        {
            cCopySample cEqual = cOrg;   // 참조
            fCopy(cEqual);
        }

        private void fShallowCopy()
        {
            cCopySample cShallow = (cCopySample)cOrg.ShallowCopy();   // 얕은Copy
            fCopy(cShallow);
        }

        private void fDeepCopy()
        {
            cCopySample cDeep = cOrg.Clone() as cCopySample;   //깊은Copy
            fCopy(cDeep);
        }

        private void fCopy(cCopySample cCopy)
        {
            cCopy.iCopy = int.Parse(tboxInt.Text);
            cCopy.charCopy = char.Parse(tboxChar.Text);

            cCopy.arrCopy[0] = int.Parse(tboxIntArray.Text);
            cCopy.claCopy.iValue = int.Parse(tboxClassNumber.Text);

            // Copy 결과
            lblCopyData.Text = $"{cCopy.iCopy}, {cCopy.charCopy}, [{string.Join(",",cCopy.arrCopy)}], {cCopy.claCopy.iValue}";

            // Copy 후 Origin Data
            lblOrgData.Text = $"{cOrg.iCopy}, {cOrg.charCopy}, [{string.Join(",", cOrg.arrCopy)}], {cOrg.claCopy.iValue}";
        }
    }
}
