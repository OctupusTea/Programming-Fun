namespace Everwing_Egg_Chance_Optimizor
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			this.group_initial = new System.Windows.Forms.GroupBox();
			this.button_initial_start = new System.Windows.Forms.Button();
			this.button_initial_reset = new System.Windows.Forms.Button();
			this.value_initial_bonus = new System.Windows.Forms.NumericUpDown();
			this.value_initial_trophy = new System.Windows.Forms.NumericUpDown();
			this.value_initial_coin = new System.Windows.Forms.NumericUpDown();
			this.label_initial_coin = new System.Windows.Forms.Label();
			this.label_initial_bonus = new System.Windows.Forms.Label();
			this.label_initial_trophy = new System.Windows.Forms.Label();
			this.group_current = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label_dragon_count = new System.Windows.Forms.Label();
			this.label_legend_count = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label_rare_count = new System.Windows.Forms.Label();
			this.value_dragon_count = new System.Windows.Forms.Label();
			this.value_current_bonus = new System.Windows.Forms.Label();
			this.value_legend_count = new System.Windows.Forms.Label();
			this.value_rare_count = new System.Windows.Forms.Label();
			this.value_magical_egg = new System.Windows.Forms.Label();
			this.value_legend = new System.Windows.Forms.Label();
			this.value_magical_legend = new System.Windows.Forms.Label();
			this.value_golden_legend = new System.Windows.Forms.Label();
			this.value_golden_egg = new System.Windows.Forms.Label();
			this.value_current_trophy = new System.Windows.Forms.Label();
			this.value_current_coin = new System.Windows.Forms.Label();
			this.label_legend_expectation_value = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label_megical_egg = new System.Windows.Forms.Label();
			this.label_golden_egg = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button_magical_legend = new System.Windows.Forms.Button();
			this.button_golden_legend = new System.Windows.Forms.Button();
			this.button_exit = new System.Windows.Forms.Button();
			this.button_legend_bonus = new System.Windows.Forms.Button();
			this.button_magical_rare = new System.Windows.Forms.Button();
			this.button_golden_rare = new System.Windows.Forms.Button();
			this.group_initial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.value_initial_bonus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.value_initial_trophy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.value_initial_coin)).BeginInit();
			this.group_current.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// group_initial
			// 
			this.group_initial.Controls.Add(this.button_initial_start);
			this.group_initial.Controls.Add(this.button_initial_reset);
			this.group_initial.Controls.Add(this.value_initial_bonus);
			this.group_initial.Controls.Add(this.value_initial_trophy);
			this.group_initial.Controls.Add(this.value_initial_coin);
			this.group_initial.Controls.Add(this.label_initial_coin);
			this.group_initial.Controls.Add(this.label_initial_bonus);
			this.group_initial.Controls.Add(this.label_initial_trophy);
			this.group_initial.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.group_initial.Location = new System.Drawing.Point(12, 12);
			this.group_initial.Name = "group_initial";
			this.group_initial.Size = new System.Drawing.Size(203, 289);
			this.group_initial.TabIndex = 0;
			this.group_initial.TabStop = false;
			this.group_initial.Text = "初始條件";
			// 
			// button_initial_start
			// 
			this.button_initial_start.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_initial_start.Location = new System.Drawing.Point(125, 241);
			this.button_initial_start.Name = "button_initial_start";
			this.button_initial_start.Size = new System.Drawing.Size(72, 42);
			this.button_initial_start.TabIndex = 2;
			this.button_initial_start.Text = "開始";
			this.button_initial_start.UseVisualStyleBackColor = true;
			this.button_initial_start.Click += new System.EventHandler(this.button_initial_start_Click);
			// 
			// button_initial_reset
			// 
			this.button_initial_reset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_initial_reset.Location = new System.Drawing.Point(6, 241);
			this.button_initial_reset.Name = "button_initial_reset";
			this.button_initial_reset.Size = new System.Drawing.Size(72, 42);
			this.button_initial_reset.TabIndex = 2;
			this.button_initial_reset.Text = "重置";
			this.button_initial_reset.UseVisualStyleBackColor = true;
			this.button_initial_reset.Click += new System.EventHandler(this.button_initial_reset_Click);
			// 
			// value_initial_bonus
			// 
			this.value_initial_bonus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.value_initial_bonus.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.value_initial_bonus.Location = new System.Drawing.Point(6, 113);
			this.value_initial_bonus.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.value_initial_bonus.Name = "value_initial_bonus";
			this.value_initial_bonus.Size = new System.Drawing.Size(75, 34);
			this.value_initial_bonus.TabIndex = 1;
			this.value_initial_bonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.value_initial_bonus.ThousandsSeparator = true;
			this.value_initial_bonus.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.value_initial_bonus.ValueChanged += new System.EventHandler(this.value_initial_bonus_ValueChanged);
			// 
			// value_initial_trophy
			// 
			this.value_initial_trophy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.value_initial_trophy.Increment = new decimal(new int[] {
            1100,
            0,
            0,
            0});
			this.value_initial_trophy.Location = new System.Drawing.Point(6, 73);
			this.value_initial_trophy.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.value_initial_trophy.Name = "value_initial_trophy";
			this.value_initial_trophy.Size = new System.Drawing.Size(133, 34);
			this.value_initial_trophy.TabIndex = 1;
			this.value_initial_trophy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.value_initial_trophy.ThousandsSeparator = true;
			this.value_initial_trophy.ValueChanged += new System.EventHandler(this.value_initial_trophy_ValueChanged);
			// 
			// value_initial_coin
			// 
			this.value_initial_coin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.value_initial_coin.Increment = new decimal(new int[] {
            28000,
            0,
            0,
            0});
			this.value_initial_coin.Location = new System.Drawing.Point(6, 33);
			this.value_initial_coin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.value_initial_coin.Name = "value_initial_coin";
			this.value_initial_coin.Size = new System.Drawing.Size(133, 34);
			this.value_initial_coin.TabIndex = 1;
			this.value_initial_coin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.value_initial_coin.ThousandsSeparator = true;
			this.value_initial_coin.ValueChanged += new System.EventHandler(this.value_initial_coin_ValueChanged);
			// 
			// label_initial_coin
			// 
			this.label_initial_coin.AutoSize = true;
			this.label_initial_coin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label_initial_coin.Location = new System.Drawing.Point(145, 35);
			this.label_initial_coin.Name = "label_initial_coin";
			this.label_initial_coin.Size = new System.Drawing.Size(52, 25);
			this.label_initial_coin.TabIndex = 0;
			this.label_initial_coin.Text = "金幣";
			// 
			// label_initial_bonus
			// 
			this.label_initial_bonus.AutoSize = true;
			this.label_initial_bonus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label_initial_bonus.Location = new System.Drawing.Point(87, 115);
			this.label_initial_bonus.Name = "label_initial_bonus";
			this.label_initial_bonus.Size = new System.Drawing.Size(110, 25);
			this.label_initial_bonus.TabIndex = 0;
			this.label_initial_bonus.Text = "%傳說加成";
			// 
			// label_initial_trophy
			// 
			this.label_initial_trophy.AutoSize = true;
			this.label_initial_trophy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label_initial_trophy.Location = new System.Drawing.Point(145, 75);
			this.label_initial_trophy.Name = "label_initial_trophy";
			this.label_initial_trophy.Size = new System.Drawing.Size(52, 25);
			this.label_initial_trophy.TabIndex = 0;
			this.label_initial_trophy.Text = "獎盃";
			// 
			// group_current
			// 
			this.group_current.Controls.Add(this.label5);
			this.group_current.Controls.Add(this.label_dragon_count);
			this.group_current.Controls.Add(this.label_legend_count);
			this.group_current.Controls.Add(this.label4);
			this.group_current.Controls.Add(this.label_rare_count);
			this.group_current.Controls.Add(this.value_dragon_count);
			this.group_current.Controls.Add(this.value_current_bonus);
			this.group_current.Controls.Add(this.value_legend_count);
			this.group_current.Controls.Add(this.value_rare_count);
			this.group_current.Controls.Add(this.value_magical_egg);
			this.group_current.Controls.Add(this.value_legend);
			this.group_current.Controls.Add(this.value_magical_legend);
			this.group_current.Controls.Add(this.value_golden_legend);
			this.group_current.Controls.Add(this.value_golden_egg);
			this.group_current.Controls.Add(this.value_current_trophy);
			this.group_current.Controls.Add(this.value_current_coin);
			this.group_current.Controls.Add(this.label_legend_expectation_value);
			this.group_current.Controls.Add(this.label3);
			this.group_current.Controls.Add(this.label_megical_egg);
			this.group_current.Controls.Add(this.label_golden_egg);
			this.group_current.Controls.Add(this.label2);
			this.group_current.Controls.Add(this.label1);
			this.group_current.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.group_current.Location = new System.Drawing.Point(221, 12);
			this.group_current.Name = "group_current";
			this.group_current.Size = new System.Drawing.Size(519, 289);
			this.group_current.TabIndex = 1;
			this.group_current.TabStop = false;
			this.group_current.Text = "現在狀態";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(162, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 25);
			this.label5.TabIndex = 5;
			this.label5.Text = "累計傳說期望值";
			// 
			// label_dragon_count
			// 
			this.label_dragon_count.AutoSize = true;
			this.label_dragon_count.Location = new System.Drawing.Point(61, 260);
			this.label_dragon_count.Name = "label_dragon_count";
			this.label_dragon_count.Size = new System.Drawing.Size(92, 25);
			this.label_dragon_count.TabIndex = 5;
			this.label_dragon_count.Text = "累計數量";
			// 
			// label_legend_count
			// 
			this.label_legend_count.AutoSize = true;
			this.label_legend_count.Location = new System.Drawing.Point(61, 228);
			this.label_legend_count.Name = "label_legend_count";
			this.label_legend_count.Size = new System.Drawing.Size(92, 25);
			this.label_legend_count.TabIndex = 5;
			this.label_legend_count.Text = "累計傳說";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(381, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 32);
			this.label4.TabIndex = 4;
			this.label4.Text = "0.000";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label_rare_count
			// 
			this.label_rare_count.AutoSize = true;
			this.label_rare_count.Location = new System.Drawing.Point(61, 196);
			this.label_rare_count.Name = "label_rare_count";
			this.label_rare_count.Size = new System.Drawing.Size(92, 25);
			this.label_rare_count.TabIndex = 5;
			this.label_rare_count.Text = "累計稀有";
			// 
			// value_dragon_count
			// 
			this.value_dragon_count.Location = new System.Drawing.Point(161, 260);
			this.value_dragon_count.Name = "value_dragon_count";
			this.value_dragon_count.Size = new System.Drawing.Size(75, 32);
			this.value_dragon_count.TabIndex = 4;
			this.value_dragon_count.Text = "0";
			this.value_dragon_count.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// value_current_bonus
			// 
			this.value_current_bonus.Location = new System.Drawing.Point(38, 115);
			this.value_current_bonus.Name = "value_current_bonus";
			this.value_current_bonus.Size = new System.Drawing.Size(79, 32);
			this.value_current_bonus.TabIndex = 4;
			this.value_current_bonus.Text = "5";
			this.value_current_bonus.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.value_current_bonus.TextChanged += new System.EventHandler(this.value_current_bonus_TextChanged);
			// 
			// value_legend_count
			// 
			this.value_legend_count.Location = new System.Drawing.Point(161, 228);
			this.value_legend_count.Name = "value_legend_count";
			this.value_legend_count.Size = new System.Drawing.Size(75, 32);
			this.value_legend_count.TabIndex = 4;
			this.value_legend_count.Text = "0";
			this.value_legend_count.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.value_legend_count.TextChanged += new System.EventHandler(this.value_legend_count_TextChanged);
			// 
			// value_rare_count
			// 
			this.value_rare_count.Location = new System.Drawing.Point(161, 196);
			this.value_rare_count.Name = "value_rare_count";
			this.value_rare_count.Size = new System.Drawing.Size(75, 32);
			this.value_rare_count.TabIndex = 4;
			this.value_rare_count.Text = "0";
			this.value_rare_count.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.value_rare_count.TextChanged += new System.EventHandler(this.value_rare_count_TextChanged);
			// 
			// value_magical_egg
			// 
			this.value_magical_egg.Location = new System.Drawing.Point(161, 75);
			this.value_magical_egg.Name = "value_magical_egg";
			this.value_magical_egg.Size = new System.Drawing.Size(75, 32);
			this.value_magical_egg.TabIndex = 4;
			this.value_magical_egg.Text = "0";
			this.value_magical_egg.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.value_magical_egg.TextChanged += new System.EventHandler(this.value_magical_egg_TextChanged);
			// 
			// value_legend
			// 
			this.value_legend.Location = new System.Drawing.Point(381, 115);
			this.value_legend.Name = "value_legend";
			this.value_legend.Size = new System.Drawing.Size(75, 32);
			this.value_legend.TabIndex = 4;
			this.value_legend.Text = "0.000";
			this.value_legend.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// value_magical_legend
			// 
			this.value_magical_legend.Location = new System.Drawing.Point(381, 75);
			this.value_magical_legend.Name = "value_magical_legend";
			this.value_magical_legend.Size = new System.Drawing.Size(75, 32);
			this.value_magical_legend.TabIndex = 4;
			this.value_magical_legend.Text = "0.000";
			this.value_magical_legend.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.value_magical_legend.TextChanged += new System.EventHandler(this.value_magical_legend_TextChanged);
			// 
			// value_golden_legend
			// 
			this.value_golden_legend.Location = new System.Drawing.Point(381, 35);
			this.value_golden_legend.Name = "value_golden_legend";
			this.value_golden_legend.Size = new System.Drawing.Size(75, 32);
			this.value_golden_legend.TabIndex = 4;
			this.value_golden_legend.Text = "0.000";
			this.value_golden_legend.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.value_golden_legend.TextChanged += new System.EventHandler(this.value_golden_legend_TextChanged);
			// 
			// value_golden_egg
			// 
			this.value_golden_egg.Location = new System.Drawing.Point(161, 35);
			this.value_golden_egg.Name = "value_golden_egg";
			this.value_golden_egg.Size = new System.Drawing.Size(75, 32);
			this.value_golden_egg.TabIndex = 4;
			this.value_golden_egg.Text = "0";
			this.value_golden_egg.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.value_golden_egg.TextChanged += new System.EventHandler(this.value_golden_egg_TextChanged);
			// 
			// value_current_trophy
			// 
			this.value_current_trophy.Location = new System.Drawing.Point(24, 75);
			this.value_current_trophy.Name = "value_current_trophy";
			this.value_current_trophy.Size = new System.Drawing.Size(93, 32);
			this.value_current_trophy.TabIndex = 4;
			this.value_current_trophy.Text = "0";
			this.value_current_trophy.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.value_current_trophy.TextChanged += new System.EventHandler(this.value_current_trophy_TextChanged);
			// 
			// value_current_coin
			// 
			this.value_current_coin.Location = new System.Drawing.Point(24, 35);
			this.value_current_coin.Name = "value_current_coin";
			this.value_current_coin.Size = new System.Drawing.Size(93, 32);
			this.value_current_coin.TabIndex = 4;
			this.value_current_coin.Text = "0";
			this.value_current_coin.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.value_current_coin.TextChanged += new System.EventHandler(this.value_current_coin_TextChanged);
			// 
			// label_legend_expectation_value
			// 
			this.label_legend_expectation_value.AutoSize = true;
			this.label_legend_expectation_value.Location = new System.Drawing.Point(202, 115);
			this.label_legend_expectation_value.Name = "label_legend_expectation_value";
			this.label_legend_expectation_value.Size = new System.Drawing.Size(112, 25);
			this.label_legend_expectation_value.TabIndex = 3;
			this.label_legend_expectation_value.Text = "傳說期望值";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(123, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "→";
			// 
			// label_megical_egg
			// 
			this.label_megical_egg.AutoSize = true;
			this.label_megical_egg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label_megical_egg.Location = new System.Drawing.Point(242, 75);
			this.label_megical_egg.Name = "label_megical_egg";
			this.label_megical_egg.Size = new System.Drawing.Size(72, 25);
			this.label_megical_egg.TabIndex = 2;
			this.label_megical_egg.Text = "魔法蛋";
			// 
			// label_golden_egg
			// 
			this.label_golden_egg.AutoSize = true;
			this.label_golden_egg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label_golden_egg.Location = new System.Drawing.Point(242, 35);
			this.label_golden_egg.Name = "label_golden_egg";
			this.label_golden_egg.Size = new System.Drawing.Size(72, 25);
			this.label_golden_egg.TabIndex = 2;
			this.label_golden_egg.Text = "金　蛋";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(123, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "→";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(123, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "%";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button_magical_legend);
			this.groupBox1.Controls.Add(this.button_golden_legend);
			this.groupBox1.Controls.Add(this.button_exit);
			this.groupBox1.Controls.Add(this.button_legend_bonus);
			this.groupBox1.Controls.Add(this.button_magical_rare);
			this.groupBox1.Controls.Add(this.button_golden_rare);
			this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox1.Location = new System.Drawing.Point(746, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 289);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "抽蛋控制";
			// 
			// button_magical_legend
			// 
			this.button_magical_legend.Enabled = false;
			this.button_magical_legend.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_magical_legend.Location = new System.Drawing.Point(98, 70);
			this.button_magical_legend.Name = "button_magical_legend";
			this.button_magical_legend.Size = new System.Drawing.Size(80, 34);
			this.button_magical_legend.TabIndex = 2;
			this.button_magical_legend.Text = "傳說";
			this.button_magical_legend.UseVisualStyleBackColor = true;
			this.button_magical_legend.Click += new System.EventHandler(this.button_magical_legend_Click);
			// 
			// button_golden_legend
			// 
			this.button_golden_legend.Enabled = false;
			this.button_golden_legend.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_golden_legend.Location = new System.Drawing.Point(98, 30);
			this.button_golden_legend.Name = "button_golden_legend";
			this.button_golden_legend.Size = new System.Drawing.Size(80, 34);
			this.button_golden_legend.TabIndex = 2;
			this.button_golden_legend.Text = "傳說";
			this.button_golden_legend.UseVisualStyleBackColor = true;
			this.button_golden_legend.Click += new System.EventHandler(this.button_golden_legend_Click);
			// 
			// button_exit
			// 
			this.button_exit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_exit.Location = new System.Drawing.Point(6, 241);
			this.button_exit.Name = "button_exit";
			this.button_exit.Size = new System.Drawing.Size(172, 42);
			this.button_exit.TabIndex = 2;
			this.button_exit.Text = "沒錢了怒不抽";
			this.button_exit.UseVisualStyleBackColor = true;
			this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
			// 
			// button_legend_bonus
			// 
			this.button_legend_bonus.Enabled = false;
			this.button_legend_bonus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_legend_bonus.Location = new System.Drawing.Point(6, 110);
			this.button_legend_bonus.Name = "button_legend_bonus";
			this.button_legend_bonus.Size = new System.Drawing.Size(172, 67);
			this.button_legend_bonus.TabIndex = 2;
			this.button_legend_bonus.Text = "別人抽到傳說了我要怨恨他";
			this.button_legend_bonus.UseVisualStyleBackColor = true;
			this.button_legend_bonus.Click += new System.EventHandler(this.button_legend_bonus_Click);
			// 
			// button_magical_rare
			// 
			this.button_magical_rare.Enabled = false;
			this.button_magical_rare.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_magical_rare.Location = new System.Drawing.Point(6, 70);
			this.button_magical_rare.Name = "button_magical_rare";
			this.button_magical_rare.Size = new System.Drawing.Size(80, 34);
			this.button_magical_rare.TabIndex = 2;
			this.button_magical_rare.Text = "稀有";
			this.button_magical_rare.UseVisualStyleBackColor = true;
			this.button_magical_rare.Click += new System.EventHandler(this.button_magical_rare_Click);
			// 
			// button_golden_rare
			// 
			this.button_golden_rare.Enabled = false;
			this.button_golden_rare.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_golden_rare.Location = new System.Drawing.Point(6, 30);
			this.button_golden_rare.Name = "button_golden_rare";
			this.button_golden_rare.Size = new System.Drawing.Size(80, 34);
			this.button_golden_rare.TabIndex = 2;
			this.button_golden_rare.Text = "稀有";
			this.button_golden_rare.UseVisualStyleBackColor = true;
			this.button_golden_rare.Click += new System.EventHandler(this.button_golden_rare_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(942, 313);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.group_current);
			this.Controls.Add(this.group_initial);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "曾經翅膀（？）抽蛋統計小工具";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.group_initial.ResumeLayout(false);
			this.group_initial.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.value_initial_bonus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.value_initial_trophy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.value_initial_coin)).EndInit();
			this.group_current.ResumeLayout(false);
			this.group_current.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_initial;
        private System.Windows.Forms.Label label_initial_trophy;
        private System.Windows.Forms.Label label_initial_coin;
        private System.Windows.Forms.NumericUpDown value_initial_coin;
        private System.Windows.Forms.NumericUpDown value_initial_trophy;
        private System.Windows.Forms.Button button_initial_start;
        private System.Windows.Forms.Button button_initial_reset;
        private System.Windows.Forms.NumericUpDown value_initial_bonus;
        private System.Windows.Forms.Label label_initial_bonus;
        private System.Windows.Forms.GroupBox group_current;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_golden_egg;
        private System.Windows.Forms.Label label_megical_egg;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button_magical_legend;
		private System.Windows.Forms.Button button_golden_legend;
		private System.Windows.Forms.Button button_magical_rare;
		private System.Windows.Forms.Button button_golden_rare;
		private System.Windows.Forms.Button button_legend_bonus;
		private System.Windows.Forms.Button button_exit;
		private System.Windows.Forms.Label label_legend_expectation_value;
		private System.Windows.Forms.Label value_current_bonus;
		private System.Windows.Forms.Label value_current_coin;
		private System.Windows.Forms.Label value_magical_egg;
		private System.Windows.Forms.Label value_golden_egg;
		private System.Windows.Forms.Label value_magical_legend;
		private System.Windows.Forms.Label value_golden_legend;
		private System.Windows.Forms.Label value_current_trophy;
		private System.Windows.Forms.Label value_legend;
		private System.Windows.Forms.Label label_legend_count;
		private System.Windows.Forms.Label label_rare_count;
		private System.Windows.Forms.Label value_rare_count;
		private System.Windows.Forms.Label value_legend_count;
		private System.Windows.Forms.Label label_dragon_count;
		private System.Windows.Forms.Label value_dragon_count;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
	}
}

