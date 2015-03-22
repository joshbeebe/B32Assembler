using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B32Machine
{
    public partial class MainForm : Form
    {
        private byte[] B32Memory;
        private ushort StartAddr;
        private ushort ExecAddr;
        private ushort InstructionPointer;
        private byte Register_A;
        private byte Register_B;
        private ushort Register_Y;
        private ushort Register_X;
        private ushort Register_D;

        enum Instructions
        {
            LDX = 0x02,
            LDA = 0x01,
            STA = 0x03,
            END = 0x04,
            CMPA = 0x05,
            CMPB = 0x06,
            CMPX = 0x07,
            CMPY = 0x08,
            CMPD = 0x09,
            JMP = 0x0a,
            JEQ = 0x0b,
            JNE = 0x0c,
            JGT = 0x0d,
            JLT = 0x0e
        };

        public MainForm()
        {
            InitializeComponent();

            B32Memory = new byte[65535];
            StartAddr = 0;
            ExecAddr = 0;
            Register_A = 0;
            Register_B = 0;
            Register_D = 0;
            Register_X = 0;
            Register_Y = 0;
            UpdateRegisterStatus();
        }

        private void UpdateRegisterStatus()
        {
            string strRegisters = "";

            strRegisters = "Register A = $" + Register_A.ToString("X").PadLeft(2, '0');
            strRegisters += "     Register B = $" + Register_B.ToString("X").PadLeft(2, '0');
            strRegisters += "     Register D = $" + Register_D.ToString("X").PadLeft(4, '0');
            strRegisters += "\nRegister X = $" + Register_X.ToString("X").PadLeft(4, '0');
            strRegisters += "     Register Y = $" + Register_Y.ToString("X").PadLeft(4, '0');
            strRegisters += "     Instruction Pointer = $" + InstructionPointer.ToString("X").PadLeft(4, '0');
            this.lblRegisters.Text = strRegisters;

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tstFrm = new B32Assembler.frmMainForm();
            tstFrm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte Magic1, Magic2, Magic3;

            openFileDialog1.ShowDialog();

            System.IO.BinaryReader br;
            System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open);

            br = new System.IO.BinaryReader(fs);
            Magic1 = br.ReadByte();
            Magic2 = br.ReadByte();
            Magic3 = br.ReadByte();

            if (Magic1 != 'B' || Magic2 != '3' || Magic3 != '2')
            {
                MessageBox.Show("This is not a valid B32 file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StartAddr = br.ReadUInt16();
            Console.WriteLine("Start Address: " + StartAddr);
            ExecAddr = br.ReadUInt16();
            Console.WriteLine("Exec Address: " + ExecAddr);
            ushort Counter = 0;
            while (br.PeekChar() != -1)
            {
                B32Memory[StartAddr + Counter] = br.ReadByte();
                Counter++;
            }
            br.Close();
            fs.Close();
            InstructionPointer = (ushort)(StartAddr + ExecAddr);
            Console.WriteLine("InstructionPointer: " + InstructionPointer);
            ExecuteProgram(ExecAddr, Counter);
        }

        private void ExecuteProgram(ushort ExecAddr, ushort ProgLength)
        {
            Console.WriteLine("In ExecuteProgram");
            ProgLength = 64000;
            while (ProgLength > 0)
            {
                Instructions instruction = (Instructions)B32Memory[InstructionPointer];
                ProgLength--;
                if (instruction == Instructions.LDX)
                {
                    Register_X = (ushort)(B32Memory[InstructionPointer + 2] << 8);
                    Register_X += B32Memory[InstructionPointer + 1];
                    ProgLength -= 2;
                    InstructionPointer += 3;
                    UpdateRegisterStatus();
                    continue;
                }

                if (instruction == Instructions.LDA)
                {
                    Register_A = B32Memory[InstructionPointer + 1];
                    SetRegisterD();
                    ProgLength -= 1;
                    InstructionPointer += 2;

                    UpdateRegisterStatus();
                    continue;
                }
                if (instruction == Instructions.STA)
                {
                    Console.WriteLine("Poking");
                    B32Memory[Register_X] = Register_A;
                    b32Screen1.Poke(Register_X, Register_A);
                    InstructionPointer++;
                    UpdateRegisterStatus();
                    continue;
                }
                if (instruction == Instructions.END)
                {
                    InstructionPointer++;
                    UpdateRegisterStatus();
                    break;
                }

            }
        }

        private void SetRegisterD()
        {
            Register_D = (ushort)(Register_A << 8 + Register_B);
        }

        private void assemblerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tstFrm = new B32Assembler.frmMainForm();
            tstFrm.Show();
        }

    }
}
