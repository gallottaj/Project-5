namespace Project5
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yearListBox = new System.Windows.Forms.ListBox();
            this.monthListBox = new System.Windows.Forms.ListBox();
            this.dayListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearListBox
            // 
            this.yearListBox.FormattingEnabled = true;
            this.yearListBox.ItemHeight = 16;
            this.yearListBox.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.yearListBox.Location = new System.Drawing.Point(307, 114);
            this.yearListBox.Name = "yearListBox";
            this.yearListBox.Size = new System.Drawing.Size(120, 20);
            this.yearListBox.TabIndex = 0;
            this.yearListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // monthListBox
            // 
            this.monthListBox.FormattingEnabled = true;
            this.monthListBox.ItemHeight = 16;
            this.monthListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthListBox.Location = new System.Drawing.Point(307, 166);
            this.monthListBox.Name = "monthListBox";
            this.monthListBox.Size = new System.Drawing.Size(120, 20);
            this.monthListBox.TabIndex = 1;
            this.monthListBox.SelectedIndexChanged += new System.EventHandler(this.monthListBox_SelectedIndexChanged);
            // 
            // dayListBox
            // 
            this.dayListBox.FormattingEnabled = true;
            this.dayListBox.ItemHeight = 16;
            this.dayListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayListBox.Location = new System.Drawing.Point(307, 219);
            this.dayListBox.Name = "dayListBox";
            this.dayListBox.Size = new System.Drawing.Size(120, 20);
            this.dayListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Birth Year";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Birth Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Birth Day";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Get Lucky Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayListBox);
            this.Controls.Add(this.monthListBox);
            this.Controls.Add(this.yearListBox);
            this.Name = "MainForm";
            this.Text = "Lucky Number Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox yearListBox;
        private System.Windows.Forms.ListBox monthListBox;
        private System.Windows.Forms.ListBox dayListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}