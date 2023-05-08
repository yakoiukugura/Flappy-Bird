using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // variabile pentru controlul jocului
        int SPEED = 3; // viteza conductelor
        int GRAVITY = 5; // forța gravitației
        int SCORE = 0; // scorul jocului

        private void start_button_Click(object sender, EventArgs e)
        {
            // resetează scorul și viteza la începutul jocului
            SCORE = 0;
            SPEED = 3;

            // ascunde meniul și butoanele de start/renunțare
            menu.Enabled = false;
            menu.Visible = false;
            start_button.Enabled = false;
            start_button.Visible = false;
            quit_button.Enabled = false;
            quit_button.Visible = false;
            // afișează scorul jocului
            txtScore.Visible = true;
            txtScore.Enabled = true;

            // resetează poziția pasării și a conductelor
            bird.Location = new Point(22, 170);
            pipeDown.Location = new Point(360, -46);
            pipeUp.Location = new Point(678, 319);
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            // afișează un dialog de confirmare pentru ieșirea din joc
            if (MessageBox.Show("Are you sure you want to quit?", "Quit Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // asigură faptul că fereastra jocului este focusată
            this.Focus();

            // mișcă conductele și pasărea
            pipeDown.Left -= SPEED;
            pipeUp.Left -= SPEED;
            bird.Top += GRAVITY;

            // actualizează scorul și resetează conductele la capătul din stânga al ferestrei
            if (pipeDown.Left < -pipeDown.Width)
            {
                pipeDown.Left = 670;
                SCORE++;
            }
            if (pipeUp.Left < -pipeUp.Width)
            {
                pipeUp.Left = 670;
                SCORE++;
            }

            // verifică dacă pasărea s-a ciocnit cu o conductă sau cu solul
            if (bird.Bounds.IntersectsWith(pipeUp.Bounds) || bird.Bounds.IntersectsWith(pipeDown.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver(); // apelează funcția de terminare a jocului
            }
        }

        private void gameOver()
        {
            // oprim timerul
            timer1.Enabled = false;

            // asteptam un moment
            wait(1000);

            // afisam meniul de start
            menu.Enabled = true;
            menu.Visible = true;

            // afisam un mesaj de "Game Over"
            title.Text = "Game Over!";
            title.Enabled = true;
            title.Visible = true;

            // afisam butonul de restart si butonul de quit
            start_button.Text = "Play Again";
            start_button.Enabled = true;
            start_button.Visible = true;
            quit_button.Enabled = true;
            quit_button.Visible = true;

            // afisam scorul final
            txtScore.Text = "Score: " + SCORE;
            txtScore.Visible = true;
            txtScore.Enabled = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // cand se elibereaza o tasta, pasarea incepe sa cada
            GRAVITY = -GRAVITY;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Enabled = true;
            GRAVITY = -GRAVITY; // Inverseaza valoarea variabilei GRAVITY
        }

        /*  Functia wait() asteapta un anumit numar de milisecunde inainte de a continua executia programului. 
        Aceasta functie se utilizeaza aici pentru a astepta un interval de timp inainte de a activa meniul de joc 
        de dupa ce jucatorul pierde. */
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
