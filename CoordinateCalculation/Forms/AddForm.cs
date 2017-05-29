using System;
using System.Windows.Forms;
using CoordinateCalculation;
using System.Globalization;

namespace Forms
{
    public partial class AddForm : Form
    { private IMotion motioon;
    ///
    ///
    ///

    
        public AddForm()
        {
            InitializeComponent();
        }
        public IMotion CoordinateCalculation
        {
            get
            {
                if (MotionComboBox.SelectedIndex == 0)
                {
                    var accelerated = new Accelerated
                    {
                        Time = Convert.ToInt32(TimeTextBox.Text),
                        StartCoordinate = Convert.ToInt32(StartCoordinateTextBox.Text),
                        StartSpeed = Convert.ToInt32(StartSpeedTextBox.Text),
                        Acceleration = Convert.ToInt32(Acceleration.Text)
                    };
                    motioon = accelerated;

                }
                else if (MotionComboBox.SelectedIndex == 1)
                {
                    var vibrating = new Vibrating
                    {
                        Time = Convert.ToInt32(TimeTextBox.Text),
                        StartCoordinate = Convert.ToInt32(StartCoordinateTextBox.Text),
                        StartPhase = Convert.ToInt32(StartSpeedTextBox.Text),
                        Amplitude = Convert.ToInt32(StartSpeedTextBox.Text),
                        Frequency = Convert.ToInt32(StartSpeedTextBox.Text)
                    };
                    motioon = vibrating;
                }
                else if (MotionComboBox.SelectedIndex == 2)
                {
                    var uniforms = new Uniform
                    {
                        Time = Convert.ToInt32(TimeTextBox.Text),
                        StartCoordinate = Convert.ToInt32(StartCoordinateTextBox.Text),
                        StartSpeed = Convert.ToInt32(StartCoordinateTextBox.Text)

                    };
                    motioon = uniforms;

                }
                return motioon;
            }
            set
            {

                if (value is Uniform)
                {
                    var uniforms = (Uniform)value;
                    MotionComboBox.SelectedIndex = 1;
                    MotionComboBox.Enabled = false;

                    StartSpeedTextBox.Text = uniforms.StartSpeed.ToString(CultureInfo.InvariantCulture);
                    StartCoordinateTextBox.Text = uniforms.StartCoordinate.ToString(CultureInfo.InvariantCulture);
                    TimeTextBox.Text = uniforms.Time.ToString(CultureInfo.InvariantCulture);
                }
                else if (value is Accelerated)
                {
                    var accelerated = (Accelerated)value;
                    MotionComboBox.SelectedIndex = 0;
                    MotionComboBox.Enabled = false;

                    StartSpeedTextBox.Text = accelerated.StartSpeed.ToString(CultureInfo.InvariantCulture);
                    StartCoordinateTextBox.Text = accelerated.StartCoordinate.ToString(CultureInfo.InvariantCulture);
                    TimeTextBox.Text = accelerated.Time.ToString(CultureInfo.InvariantCulture);
                    Acceleration.Text = accelerated.Acceleration.ToString(CultureInfo.InvariantCulture);
                }
                else if (value is Vibrating)
                {
                    var vibrating = (Vibrating)value;
                    MotionComboBox.SelectedIndex = 2;
                    MotionComboBox.Enabled = false;

                    StartSpeedTextBox.Text = vibrating.StartCoordinate.ToString(CultureInfo.InvariantCulture);
                    StartPhaseTextBox.Text = vibrating.StartPhase.ToString(CultureInfo.InvariantCulture);
                    TimeTextBox.Text = vibrating.Time.ToString(CultureInfo.InvariantCulture);
                    FreequencyTextBox.Text = vibrating.Frequency.ToString(CultureInfo.InvariantCulture);
                    AmplitudeTextBox.Text = vibrating.Amplitude.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        private void AddForms_Load(object sender, EventArgs e)
        {
            
            if(MotionComboBox.Enabled)
            {
                AddFormGroupBox.Visible = false;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void MotionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MotionComboBox.SelectedIndex == 0)
            {
                TimeTextBox.Visible = true;
                StartCoordinateTextBox.Visible = true;
                StartSpeedTextBox.Visible = true;
                Acceleration.Visible = true;
                FreequencyTextBox.Visible = false;
                AmplitudeTextBox.Visible = false;
                StartPhaseTextBox.Visible = false;
                AddFormGroupBox.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }
           
            
               else if (MotionComboBox.SelectedIndex == 1)
            {
                TimeTextBox.Visible = true;
                StartCoordinateTextBox.Visible = true;
                StartSpeedTextBox.Visible = true;
                Acceleration.Visible = false;
                FreequencyTextBox.Visible = false;
                AmplitudeTextBox.Visible = false;
                StartPhaseTextBox.Visible = false;
                AddFormGroupBox.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }
            else if (MotionComboBox.SelectedIndex == 2)
            {
                TimeTextBox.Visible = true;
                StartCoordinateTextBox.Visible = true;
                StartSpeedTextBox.Visible = true;
                Acceleration.Visible = false;
                FreequencyTextBox.Visible = true;
                AmplitudeTextBox.Visible = true;
                StartPhaseTextBox.Visible = true;
                AddFormGroupBox.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FreequencyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

