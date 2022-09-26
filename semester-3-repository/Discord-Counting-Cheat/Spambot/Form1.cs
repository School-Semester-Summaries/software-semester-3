using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Spambot
{
    public partial class Form1 : Form
    {
        int _count;
        InputSimulator _sim = new InputSimulator();
        bool _doubleDigits = false;
        bool _tripleDigits = false;
        bool _quatroDigits = false;
        bool _fiveDigits = false;
        int _tiental = 96;
        int _honderdTal = 96;
        int _thousandTal = 96;
        int _tenThousandTal = 96;
        int _onePlus = 0;
        int _number = 96;

        public Form1()
        {
            InitializeComponent();
        }

        VirtualKeyCode GetNumber()
        {
            if (_number < 105)
            {
                return (VirtualKeyCode)_number++;
            }
            else if (_tiental == 105 && _number == 105 && _honderdTal == 105 && _thousandTal == 105)
            {
                int numSave = _number;
                _number = 96;
                _tiental = 96;
                _honderdTal = 96;
                _thousandTal = 96;
                _tenThousandTal++;
                _fiveDigits = true;
                return (VirtualKeyCode)numSave;
            }
            else if (_tiental == 105 && _number == 105 && _honderdTal == 105)
            {
                int numSave = _number;
                _number = 96;
                _tiental = 96;
                _honderdTal = 96;
                _thousandTal++;
                _quatroDigits = true;
                return (VirtualKeyCode)numSave;
            }
            else if (_tiental == 105 && _number == 105)
            {
                int numSave = _number;
                _number = 96;
                _tiental = 96;
                _honderdTal++;
                _tripleDigits = true;
                return (VirtualKeyCode)numSave;
            }
            else
            {
                int numSave = _number;
                _number = 96;
                _tiental++;
                _doubleDigits = true;
                return (VirtualKeyCode)numSave;
            }
            //VirtualKeyCode.NUMPAD0 = 96
            //VirtualKeyCode.NUMPAD1 = 97
            //VirtualKeyCode.NUMPAD2 = 98
            //VirtualKeyCode.NUMPAD3 = 99
            //VirtualKeyCode.NUMPAD4 = 100
            //VirtualKeyCode.NUMPAD5 = 101
            //VirtualKeyCode.NUMPAD6 = 102
            //VirtualKeyCode.NUMPAD7 = 103
            //VirtualKeyCode.NUMPAD8 = 104
            //VirtualKeyCode.NUMPAD9 = 105
        }

        void Counting()
        {
            if (!_doubleDigits)
            {
                _sim.Keyboard.KeyPress(GetNumber());
            }
            else if (_fiveDigits)
            {
                _sim.Keyboard.KeyPress((VirtualKeyCode)_tenThousandTal);
                _sim.Keyboard.KeyPress((VirtualKeyCode)_thousandTal);
                _sim.Keyboard.KeyPress((VirtualKeyCode)_honderdTal);
                _sim.Keyboard.KeyPress((VirtualKeyCode)_tiental);
                _sim.Keyboard.KeyPress(GetNumber());
            }
            else if (_quatroDigits)
            {
                _sim.Keyboard.KeyPress((VirtualKeyCode)_thousandTal);
                _sim.Keyboard.KeyPress((VirtualKeyCode)_honderdTal);
                _sim.Keyboard.KeyPress((VirtualKeyCode)_tiental);
                _sim.Keyboard.KeyPress(GetNumber());
            }
            else if (_tripleDigits)
            {
                _sim.Keyboard.KeyPress((VirtualKeyCode)_honderdTal);
                _sim.Keyboard.KeyPress((VirtualKeyCode)_tiental);
                _sim.Keyboard.KeyPress(GetNumber());
            }
            else if (_doubleDigits)
            {
                _sim.Keyboard.KeyPress((VirtualKeyCode)_tiental);
                _sim.Keyboard.KeyPress(GetNumber());
            }
            if (_number == 96 && _tiental == 103)
            {
                SendKeys.Send(" nice");
            }
            SendKeys.Send("{ENTER}");
        }

        void OnePlusOne()
        {
            _sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD1);
            for (int i = 0; i < _onePlus; i++)
            {
                _sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                _sim.Keyboard.KeyPress(VirtualKeyCode.OEM_PLUS);
                _sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                _sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD1);
            }
            _onePlus++;
            SendKeys.Send("{ENTER}");
        }

        private void TMR_Inputs_Tick(object sender, EventArgs e)
        {
            if (_count == 0)
            {
                Counting();
                Thread.Sleep(100);
                _sim.Keyboard.KeyDown(VirtualKeyCode.LMENU);
                _sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
                _sim.Keyboard.KeyUp(VirtualKeyCode.LMENU);
            }
            else
            {
                Counting();
                Thread.Sleep(100);
                _sim.Keyboard.KeyDown(VirtualKeyCode.LMENU);
                _sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
                _sim.Keyboard.KeyUp(VirtualKeyCode.LMENU);
                _count = -1;
            }
            _count++;
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            TMR_Inputs.Enabled = false;
            Reset();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1500);
            SetNumber();
            TMR_Inputs.Enabled = true;
        }

        void SetNumber()
        {
            _number = Convert.ToInt32(NUD_Digit4.Value) + 96;


            _tiental = Convert.ToInt32(NUD_Digit3.Value) + 96;
            if (_tiental > 96)
            {
                _doubleDigits = true;
            }
            _honderdTal = Convert.ToInt32(NUD_Digit2.Value) + 96;
            if (_honderdTal > 96)
            {
                _tripleDigits = true;
            }
            _thousandTal = Convert.ToInt32(NUD_Digit1.Value) + 96;
            if (_thousandTal > 96)
            {
                _quatroDigits = true;
            }
        }

        void Reset()
        {
            _doubleDigits = false;
            _tripleDigits = false;
            _quatroDigits = false;
            _fiveDigits = false;
            _tiental = 96;
            _honderdTal = 96;
            _thousandTal = 96;
            _tenThousandTal = 96;
            _count = 0;
            _number = 96;
            _onePlus = 0;
        }
    }
}

/*
 



249
251

 */