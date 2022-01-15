using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FadedToolWFA.Utils;

namespace FadedToolWFA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        utils Util = new utils();
        string didGameVersPtr = "";
        string mcidGameVersPtr = "";
        struct UniquePtr
        {
            public UniquePtr(int index, string didPtr, string mcidPtr)
            {
                this.index = index;
                this.didPtr = didPtr;
                this.mcidPtr = mcidPtr;
            }
            public int index;
            public string didPtr;
            public string mcidPtr;
        }
        //Yaami laami <3
        /*
         Format:
        SelectedIndex, DidPointer, McidPointer
        */
        List<UniquePtr> Versions = new List<UniquePtr> {
    new UniquePtr(-1, "0421B218,0,20,0", "04249B70,0,30,18,50,0"),//If user hasn't selected a game version, just just latets and copy 0
    new UniquePtr(0, "0421B218,0,20,0", "04249B70,0,30,18,50,0"),
    new UniquePtr(1, "04215D08,0,20,0", "04244650,0,30,20,60,0"),
    new UniquePtr(2, "041F4318,0,20,0", "042175D0,0,30,20,60,0"),
    new UniquePtr(3, "041F32E8,0,20,0", ""),
    new UniquePtr(4, "040776C8,3F8,218,50,2F0,0", ""),
    new UniquePtr(5, "03F54B70,D8,10,D0,50,2F0,0", ""),
    new UniquePtr(6, "03FE4618,0,4D0,280,30,40,2E0,0", ""),
    new UniquePtr(7, "03CCB7A8,10,4D0,8,260,20,2E0,0", ""),
    new UniquePtr(8, "037C7170,D0,48,218,50,2F0,0", ""),
    new UniquePtr(9, "03A17598,10,80,0,8,290,0", ""),
    new UniquePtr(10, "03582140,D0,48,80,0,8,290,0", ""),
    new UniquePtr(11, "0368EE98,80,0,8,290,0", ""),
};

        private void versionSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (UniquePtr version in Versions)
                if (versionSelectList.SelectedIndex == version.index)
                {
                    didGameVersPtr = version.didPtr;
                    mcidGameVersPtr = version.mcidPtr;
                }
        }

        private void spoofButton_Click(object sender, EventArgs e)
        {
            Util.ChangeMCIDRandom(mcidGameVersPtr);
            Util.ChangeIdRandom(didGameVersPtr);
        }
    }
}
