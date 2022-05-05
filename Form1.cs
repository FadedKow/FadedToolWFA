using System;
using System.Collections.Generic;
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
            public UniquePtr(int index, string didPtr, string mcidPtr, string x86DidPtr)
            {
                this.index = index;
                this.didPtr = didPtr;
                this.mcidPtr = mcidPtr;
                this.x86DidPtr = x86DidPtr;
            }
            public int index;
            public string didPtr;
            public string mcidPtr;
            public string x86DidPtr;
        }
        //Yaami laami <3
/*
         Format:
        SelectedIndex, DidPointer, McidPointer, x86DidPointer
*/
        List<UniquePtr> Versions = new List<UniquePtr> {
    new UniquePtr(-1, "0546B0B8,0,20,0", "054C0DE0,0,30,18,10,60,0", ""),//If user hasn't selected a game version, just use latest which should be below

    new UniquePtr(14, "0546B0B8,0,20,0", "054C0DE0,0,30,18,10,60,0", ""),//1.18.31
    new UniquePtr(13, "0458F1A8,0,20,0", "045CC590,0,30,20,60,0", ""),//1.18.12
    new UniquePtr(12, "0458F1C8,0,20,0", "045CC5F0,0,30,20,60,0", ""),//1.18.10
    new UniquePtr(11, "0421B218,0,20,0", "04249B70,0,30,18,50,0", "03A87158,0,10,0"),
    new UniquePtr(10, "04215D08,0,20,0", "04244650,0,30,20,60,0", ""),
    new UniquePtr(9, "041F4318,0,20,0", "042175D0,0,30,20,60,0", ""),
    new UniquePtr(8, "041F32E8,0,20,0", "", ""),
    new UniquePtr(7, "040776C8,3F8,218,50,2F0,0", "", ""),
    new UniquePtr(6, "03F54B70,D8,10,D0,50,2F0,0", "", ""),
    new UniquePtr(5, "03FE4618,0,4D0,280,30,40,2E0,0", "", ""),
    new UniquePtr(4, "03CCB7A8,10,4D0,8,260,20,2E0,0", "", ""),
    new UniquePtr(3, "037C7170,D0,48,218,50,2F0,0", "", ""),
    new UniquePtr(2, "03A17598,10,80,0,8,290,0", "", ""),
    new UniquePtr(1, "03582140,D0,48,80,0,8,290,0", "", ""),
    new UniquePtr(0, "0368EE98,80,0,8,290,0", "", ""),//1.16.40
};

        private void versionSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cpuSwitch.Checked)
            {
                foreach (UniquePtr version in Versions)
                    if (versionSelectList.SelectedIndex == version.index)
                    {
                        didGameVersPtr = version.didPtr;
                        mcidGameVersPtr = version.mcidPtr;
                    }
            } else
            {
                foreach (UniquePtr version in Versions)
                    if (versionSelectList.SelectedIndex == version.index)
                    {
                        didGameVersPtr = version.x86DidPtr;
                    }
            }
        }

        private void spoofButton_Click(object sender, EventArgs e)
        {
            if (!cpuSwitch.Checked)
                Util.ChangeMCIDRandom(mcidGameVersPtr);
            Util.ChangeIdRandom(didGameVersPtr);
            MessageBox.Show("Spoofed");
        }
    }
}
