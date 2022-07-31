﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Paint(object sender, EventArgs e)
        {

            
            
        }

        Bitmap myBitmap;
        Graphics g;
        int a = 0, b = 0;


        


        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(myBitmap);

            Pen pen1 = new Pen(Color.Black, 1);

            SolidBrush brush_yellow = new SolidBrush(Color.FromArgb(255, 255, 0));
            SolidBrush brush_white = new SolidBrush(Color.FromArgb( 255, 255, 255));
            SolidBrush brush_black = new SolidBrush(Color.FromArgb( 0, 0, 0));
            SolidBrush brush_red = new SolidBrush(Color.FromArgb( 255, 0, 0));
            SolidBrush brush_skin = new SolidBrush(Color.FromArgb(244, 164, 96));
            
            

            

            
            Point[] yellow_lightning =
             {
                 new Point(80,  10),
                 new Point(80, 30),
                 new Point(90,  30),
                 new Point(90, 40),
                 new Point(100,  40),
                 new Point(100,  50),
                 new Point(110,  50),
                 new Point(110,  30),
                 new Point(100,  30),
                 new Point(100,  20),
                 new Point(90,  20),
                 new Point(90,  10)

             };

            Point[] yellow_lightning2 =
             {
                 new Point(160,  10),
                 new Point(160, 30),
                 new Point(170,  30),
                 new Point(170, 40),
                 new Point(180,  40),
                 new Point(180,  20),
                 new Point(170,  20),
                 new Point(170,  10)

             };

            Point[] yellow_soak =
             {
                 new Point(160,  200),
                 new Point(160, 210),
                 new Point(150,  210),
                 new Point(150, 240),
                 new Point(220,  240),
                 new Point(220,  230),
                 new Point(200,  230),
                 new Point(200,  220),
                 new Point(180,  220),
                 new Point(180,  200),
                 

             };

            Point[] yellow_soak2 =
             {
                 new Point(90,  200),
                 new Point(90, 210),
                 new Point(100,  210),
                 new Point(100, 240),
                 new Point(30,  240),
                 new Point(30,  230),
                 new Point(50,  230),
                 new Point(50,  220),
                 new Point(70,  220),
                 new Point(70,  200),
                 

             };

            Rectangle[] hand_belts =
             {
                 new Rectangle( 90,   180   , 70, 10),
                 new Rectangle(50, 120, 10,  10),
                 new Rectangle(60, 130, 10,  10),
                 new Rectangle(70, 140, 10,  10),
                 new Rectangle(170, 140, 10,  10),
                 new Rectangle(180, 130, 10,  10),
                 new Rectangle(190, 120, 10,  10),
                 new Rectangle(140, 140, 10,  10),
                 new Rectangle(130, 150, 10,  10),
                 new Rectangle(140, 160, 10,  10),
                 new Rectangle(130, 170, 10,  10)
             };

            Rectangle[] belly =
             {
                 
                 new Rectangle(130, 140, 10,  10),
                 new Rectangle(140, 170, 10,  10)
                 
             };

            Point[] belly1 =
             {
                 new Point(120,  150),
                 new Point(120, 170),
                 new Point(140,  170),
                 new Point(140, 160),
                 new Point(130,  160),
                 new Point(130,  150),
                

             };

            Point[] belly2 =
             {
                 new Point(140,  150),
                 new Point(140, 160),
                 new Point(150,  160),
                 new Point(150, 170),
                 new Point(160,  170),
                 new Point(160,  150),
                

             };

            Point[] eye =
             {
                 new Point(110,  80),
                 new Point(110, 90),
                 new Point(120, 90),
                 new Point(120, 100),
                 new Point(130,  100),
                 new Point(130,  80),
                

             };

            Point[] eye1 =
             {
                 new Point(130,  80),
                 new Point(130, 100),
                 new Point(150, 100),
                 new Point(150, 90),
                 new Point(140,  90),
                 new Point(140,  80),
                

             };

            Rectangle[] eye_mouth =
             {
                 
                 new Rectangle(150, 100, 10,  10),
                 new Rectangle(170, 80, 10,  20)
                 
             };

            Rectangle[] black_neck =
             {
                 
                 new Rectangle(100, 120, 10,  10),
                 new Rectangle(110, 130, 50,  10),
                 new Rectangle(160, 120, 10,  10),
                 
             };

            Rectangle[] black_parts =
             {
                 
                 new Rectangle(100, 20, 70,  10),
                 new Rectangle(160, 90, 10,  10),
                 new Rectangle(160, 30, 10,  10),
                 new Rectangle(170, 40, 10,  10),
                 new Rectangle(180, 50, 10,  60),
                 new Rectangle(170, 110, 30,  10),
                 new Rectangle(200, 120, 10,  20),
                 new Rectangle(210, 140, 10,  40),
                 new Rectangle(180, 180, 30,  10),
                 new Rectangle(200, 220, 20,  10),
                 new Rectangle(200, 220, 10,  10),
                 new Rectangle(220, 230, 10,  20),
                 new Rectangle(140, 240, 80,  10),
                 new Rectangle(170, 190, 10,  10),
                 new Rectangle(140, 220, 10,  20),
                 new Rectangle(130, 210, 10,  10),
                 new Rectangle(120, 200, 10,  10),
                 new Rectangle(110, 210, 10,  10),
                 new Rectangle(100, 220, 10,  20),
                 new Rectangle(30, 240, 80,  10),
                 new Rectangle(20, 230, 10,  20),
                 new Rectangle(30, 220, 20,  10),
                 new Rectangle(70, 190, 10,  10),
                 new Rectangle(40, 180, 30,  10),
                 new Rectangle(30, 140, 10,  40),
                 new Rectangle(40, 120, 10,  20),
                 new Rectangle(50, 110, 50,  10),
                 new Rectangle(80, 90, 10,  20),
                 new Rectangle(70, 50, 10,  40),
                 new Rectangle(80, 40, 10,  10),
                 new Rectangle(130, 110, 30,  10),
                 
             };

            Point[] black_right =
             {
                 new Point(160,  140),
                 new Point(160, 190),
                 new Point(170, 190),
                 new Point(170, 180),
                 new Point(180,  180),
                 new Point(180,  160),
                 new Point(190, 160),
                 new Point(190, 150),
                 new Point(170, 150),
                 new Point(170,  140)
             };

            Point[] black_left =
             {
                 new Point(90,  140),
                 new Point(90, 190),
                 new Point(80, 190),
                 new Point(80, 180),
                 new Point(70,  180),
                 new Point(70,  160),
                 new Point(60, 160),
                 new Point(60, 150),
                 new Point(80, 150),
                 new Point(80,  140)
             };

            Point[] red_head =
             {
                 new Point(110,  30),
                 new Point(160,  30),
                 new Point(160,  40),
                 new Point(170,  40),
                 new Point(170,  50),
                 new Point(180,  50),
                 new Point(180,  110),
                 new Point(170,  110),
                 new Point(170,  90),
                 new Point(160,  90),
                 new Point(160,  100),
                 new Point(150,  100),
                 new Point(150,  90),
                 new Point(140,  90),
                 new Point(140,  80),
                 new Point(110,  80),
                 new Point(110,  90),
                 new Point(120,  90),
                 new Point(120,  100),
                 new Point(150,  100),
                 new Point(150,  110),
                 new Point(160,  110),
                 new Point(160,  100),
                 new Point(170,  100),
                 new Point(170,  110),
                 new Point(170,  120),
                 new Point(160,  120),
                 new Point(160,  130),
                 new Point(110,  130),
                 new Point(110,  120),
                 new Point(100,  120),
                 new Point(100,  110),
                 new Point(90,  110),
                 new Point(90,  90),
                 new Point(80,  90),
                 new Point(80,  50),
                 new Point(90,  50),
                 new Point(90,  40),
                 new Point(100,  40),
                 new Point(100,  50),
                 new Point(110,  50),
                 new Point(110,  30),
                 new Point(110,  30),
                // new Point(90,  140),

             };

            Point[] red_belt =
             {
                 new Point(80,  190),
                 new Point(170,  190),
                 new Point(170,  200),
                 new Point(160,  200),
                 new Point(160,  210),
                 new Point(150,  210),
                 new Point(150,  220),
                 new Point(140,  220),
                 new Point(140,  210),
                 new Point(130,  210),
                 new Point(130,  200),
                 new Point(120,  200),
                 new Point(120,  210),
                 new Point(110,  210),
                 new Point(110,  220),
                 new Point(100,  220),
                 new Point(100,  210),
                 new Point(90,  210),
                 new Point(90,  200),
                 new Point(80,  200),
                 
                 

             };

            Point[] red_hand_left =
             {
                 new Point(50,  130),
                 new Point(50,  140),
                 new Point(40,  140),
                 new Point(40,  180),
                 new Point(70,  180),
                 new Point(70,  160),
                 new Point(60,  160),
                 new Point(60,  150),
                 new Point(70,  150),
                 new Point(70,  140),
                 new Point(60,  140),
                 new Point(60,  130),
                 
                 
                 

             };

            Point[] red_hand_right =
             {
                 new Point(200,  130),
                 new Point(200,  140),
                 new Point(210,  140),
                 new Point(210,  180),
                 new Point(180,  180),
                 new Point(180,  160),
                 new Point(190,  160),
                 new Point(190,  150),
                 new Point(180,  150),
                 new Point(180,  140),
                 new Point(190,  140),
                 new Point(190,  130),
                 
                 
                 

             };

            Point[] red_soulder =
             {
                 new Point(170,  120),
                 new Point(170,  130),
                 new Point(160,  130),
                 new Point(160,  140),
                 new Point(180,  140),
                 new Point(180,  130),
                 new Point(190,  130),
                 new Point(190,  120),
                 
                 
                 

             };

            Point[] red_last_finally =
             {
                new Point(60,  120),
                new Point(60,  130),
                new Point(70,  130),
                new Point(70,  140),
                new Point(90,  140),
                new Point(90,  180),
                new Point(130,  180),
                new Point(130,  170),
                new Point(120,  170),
                new Point(120,  150),
                new Point(130,  150),
                new Point(130,  140),
                new Point(110,  140),
                new Point(110,  130),
                new Point(100,  130),
                new Point(100,  120),
               

                 
                 
                 

             };

            Point[] black_boot1 =
             {
                 new Point(60,  200),
                 new Point(60,  210),
                 new Point(50,  210),
                 new Point(50,  220),
                 new Point(70,  220),
                 new Point(70,  200),
                 
                 
                 
                 

             };

            Point[] black_boot2 =
             {
                 new Point(190,  200),
                 new Point(190,  210),
                 new Point(200,  210),
                 new Point(200,  220),
                 new Point(180,  220),
                 new Point(180,  200),
                 
                 

             };

            Rectangle[] mouth =
             {
                 
                 new Rectangle(100, 100, 10,  10),
                 new Rectangle(110, 110, 20,  10),
                 new Rectangle(110, 120, 50,  10),
                 
                 
             };




          
            g.DrawPolygon(pen1, yellow_lightning);
            g.FillPolygon(brush_yellow, yellow_lightning);

            g.DrawPolygon(pen1, yellow_lightning2);
            g.FillPolygon(brush_yellow, yellow_lightning2);

            g.DrawPolygon(pen1, yellow_soak);
            g.FillPolygon(brush_yellow, yellow_soak);

            g.DrawPolygon(pen1, yellow_soak2);
            g.FillPolygon(brush_yellow, yellow_soak2);

            g.DrawRectangles(pen1, hand_belts);
            g.FillRectangles(brush_yellow, hand_belts);

            g.DrawRectangles(pen1, belly);
            g.FillRectangles(brush_white, belly);

            g.DrawPolygon(pen1, belly1);
            g.FillPolygon(brush_white, belly1);

            g.DrawPolygon(pen1, belly2);
            g.FillPolygon(brush_white, belly2);


            g.DrawPolygon(pen1, eye);
            g.FillPolygon(brush_white, eye);


            g.DrawRectangles(pen1, eye_mouth);
            g.FillRectangles(brush_white, eye_mouth);

            

            g.DrawPolygon(pen1, black_right);
            g.FillPolygon(brush_black, black_right);

            g.DrawPolygon(pen1, black_left);
            g.FillPolygon(brush_black, black_left);

            g.DrawPolygon(pen1, eye1);
            g.FillPolygon(brush_black, eye1);

            g.DrawRectangles(pen1, black_neck);
            g.FillRectangles(brush_black, black_neck);

            g.DrawPolygon(pen1, red_head);
            g.FillPolygon(brush_red, red_head);

            g.DrawPolygon(pen1, red_belt);
            g.FillPolygon(brush_red, red_belt);

            g.DrawPolygon(pen1, red_hand_left);
            g.FillPolygon(brush_red, red_hand_left);

            g.DrawPolygon(pen1, red_hand_right);
            g.FillPolygon(brush_red, red_hand_right);


            g.DrawPolygon(pen1, red_soulder);
            g.FillPolygon(brush_red, red_soulder);

            g.DrawPolygon(pen1, red_last_finally);
            g.FillPolygon(brush_red, red_last_finally);

            
            g.DrawPolygon(pen1, black_boot1);
            g.FillPolygon(brush_black, black_boot1);

            g.DrawPolygon(pen1, black_boot2);
            g.FillPolygon(brush_black, black_boot2);

            g.DrawRectangles(pen1, mouth);
            g.FillRectangles(brush_skin, mouth);

            g.DrawRectangles(pen1, black_parts);
            g.FillRectangles(brush_black, black_parts);




            

            
            
            

            



            pictureBox1.Image = myBitmap;




             
        }
    }
}
