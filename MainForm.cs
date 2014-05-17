using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace PitchPipe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            notes = new Dictionary<string, double>();
            notes.Add("c_1", 131);
            notes.Add("csharp_1", 139);
            notes.Add("d_1", 147);
            notes.Add("dsharp_1", 156);
            notes.Add("e_1", 165);
            notes.Add("f_1", 175);
            notes.Add("fsharp_1", 185);
            notes.Add("g_1", 196);
            notes.Add("gsharp_1", 208);
            notes.Add("a_1", 220);
            notes.Add("asharp_1", 233);
            notes.Add("b_1", 247);
            notes.Add("c0", 261.6);
            notes.Add("csharp0", 277.2);
            notes.Add("d0", 293.7);
            notes.Add("dsharp0", 311.1);
            notes.Add("e0", 329.6);
            notes.Add("f0", 349.2);
            notes.Add("fsharp0", 370.0);
            notes.Add("g0", 392.0);
            notes.Add("gsharp0", 415.3);
            notes.Add("a0", 440.0);
            notes.Add("asharp0", 466.2);
            notes.Add("b0", 493.9);
            notes.Add("c", 523);
            notes.Add("csharp", 554);
            notes.Add("d", 587);
            notes.Add("dsharp", 622);
            notes.Add("e", 659);
            notes.Add("f", 698);
            notes.Add("fsharp", 740);
            notes.Add("g", 784);
            notes.Add("gsharp", 831);
            notes.Add("a", 880);
            notes.Add("asharp", 932);
            notes.Add("b", 988);
            notes.Add("c2", 1046);
            notes.Add("csharp2", 1109);
            notes.Add("d2", 1175);
            notes.Add("dsharp2", 1245);
            notes.Add("e2", 1319);
            notes.Add("f2", 1397);
            notes.Add("fsharp2", 1480);
            notes.Add("g2", 1568);
            notes.Add("gsharp2", 1661);
            notes.Add("a2", 1760);
            notes.Add("asharp2", 1865);
            notes.Add("b2", 1975);
            notes.Add("c3", 2093);
        }

        Dictionary<string, double> notes;

        private void c_Click(object sender, EventArgs e)
        {
            Console.Beep((int)notes[((Control)sender).Name], 300);
        }
    }
}
