﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        List<int> numbers = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void AddNumber_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(numberTextBox.Text))
            {
                if (int.TryParse(numberTextBox.Text, out int number))
                {
                    numbers.Add(number);
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите допустимое целое число».");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите число.");
            }
        }

        private void UpdateListBox()
        {
            numberListBox.ItemsSource = null;
            numberListBox.ItemsSource = numbers;
        }

        
    }
}