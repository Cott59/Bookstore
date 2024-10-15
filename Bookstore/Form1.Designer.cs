namespace Bookstore
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrShowBooks = new System.Windows.Forms.DataGridView();
            this.btAddBook = new System.Windows.Forms.Button();
            this.btnSetEdit = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboxShowSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxInputSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSellingPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Numbername = new System.Windows.Forms.Label();
            this.tbCostPrice = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbNameBook = new System.Windows.Forms.TextBox();
            this.tbArticul = new System.Windows.Forms.TextBox();
            this.tboxQuality = new System.Windows.Forms.TextBox();
            this.tboxSerialsBook = new System.Windows.Forms.TextBox();
            this.numSaleQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelSale = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numPrSale = new System.Windows.Forms.NumericUpDown();
            this.tbNumberOfPages = new System.Windows.Forms.TextBox();
            this.tbGanre = new System.Windows.Forms.TextBox();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnSaveEditBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrShowBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaleQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrSale)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrShowBooks
            // 
            this.dgrShowBooks.AllowUserToAddRows = false;
            this.dgrShowBooks.AllowUserToDeleteRows = false;
            this.dgrShowBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrShowBooks.Location = new System.Drawing.Point(29, 63);
            this.dgrShowBooks.Name = "dgrShowBooks";
            this.dgrShowBooks.ReadOnly = true;
            this.dgrShowBooks.Size = new System.Drawing.Size(1143, 239);
            this.dgrShowBooks.TabIndex = 0;
            // 
            // btAddBook
            // 
            this.btAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddBook.Location = new System.Drawing.Point(1205, 131);
            this.btAddBook.Name = "btAddBook";
            this.btAddBook.Size = new System.Drawing.Size(100, 52);
            this.btAddBook.TabIndex = 1;
            this.btAddBook.Text = "Добавить лот";
            this.btAddBook.UseVisualStyleBackColor = true;
            this.btAddBook.Click += new System.EventHandler(this.btAddBook_Click_1);
            // 
            // btnSetEdit
            // 
            this.btnSetEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetEdit.Location = new System.Drawing.Point(1205, 211);
            this.btnSetEdit.Name = "btnSetEdit";
            this.btnSetEdit.Size = new System.Drawing.Size(100, 53);
            this.btnSetEdit.TabIndex = 2;
            this.btnSetEdit.Text = "ВЫБРАТЬ";
            this.btnSetEdit.UseVisualStyleBackColor = true;
            this.btnSetEdit.Click += new System.EventHandler(this.btnSetEdit_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteBook.Location = new System.Drawing.Point(1050, 526);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(122, 38);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "Удалить";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSale.Location = new System.Drawing.Point(1050, 454);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(122, 45);
            this.btnSale.TabIndex = 4;
            this.btnSale.Text = "Продать";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSale.Location = new System.Drawing.Point(128, 26);
            this.btnAddSale.Margin = new System.Windows.Forms.Padding(10);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(100, 45);
            this.btnAddSale.TabIndex = 6;
            this.btnAddSale.Text = "Добавить";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(1205, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 43);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboxShowSelect
            // 
            this.cboxShowSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxShowSelect.FormattingEnabled = true;
            this.cboxShowSelect.Location = new System.Drawing.Point(131, 20);
            this.cboxShowSelect.Name = "cboxShowSelect";
            this.cboxShowSelect.Size = new System.Drawing.Size(160, 28);
            this.cboxShowSelect.TabIndex = 21;
            this.cboxShowSelect.SelectedIndexChanged += new System.EventHandler(this.cboxShowSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Показать:";
            // 
            // tboxInputSearch
            // 
            this.tboxInputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxInputSearch.Location = new System.Drawing.Point(297, 20);
            this.tboxInputSearch.Name = "tboxInputSearch";
            this.tboxInputSearch.Size = new System.Drawing.Size(146, 26);
            this.tboxInputSearch.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(16, 634);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Количество штук :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Серийность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 607);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Цена в продаже";
            // 
            // tbSellingPrice
            // 
            this.tbSellingPrice.Enabled = false;
            this.tbSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSellingPrice.Location = new System.Drawing.Point(151, 600);
            this.tbSellingPrice.Name = "tbSellingPrice";
            this.tbSellingPrice.Size = new System.Drawing.Size(174, 26);
            this.tbSellingPrice.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Себестоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Год издания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Количество страниц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Издательство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Автор";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Название книги";
            // 
            // Numbername
            // 
            this.Numbername.AutoSize = true;
            this.Numbername.Location = new System.Drawing.Point(98, 329);
            this.Numbername.Name = "Numbername";
            this.Numbername.Size = new System.Drawing.Size(48, 13);
            this.Numbername.TabIndex = 45;
            this.Numbername.Text = "Артикул";
            // 
            // tbCostPrice
            // 
            this.tbCostPrice.Enabled = false;
            this.tbCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCostPrice.Location = new System.Drawing.Point(151, 568);
            this.tbCostPrice.Name = "tbCostPrice";
            this.tbCostPrice.Size = new System.Drawing.Size(98, 26);
            this.tbCostPrice.TabIndex = 43;
            // 
            // tbYear
            // 
            this.tbYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYear.Enabled = false;
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbYear.Location = new System.Drawing.Point(152, 481);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(97, 19);
            this.tbYear.TabIndex = 42;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Enabled = false;
            this.tbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPublisher.Location = new System.Drawing.Point(152, 417);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(277, 26);
            this.tbPublisher.TabIndex = 39;
            // 
            // tbAutor
            // 
            this.tbAutor.Enabled = false;
            this.tbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAutor.Location = new System.Drawing.Point(152, 385);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(277, 26);
            this.tbAutor.TabIndex = 38;
            // 
            // tbNameBook
            // 
            this.tbNameBook.Enabled = false;
            this.tbNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameBook.Location = new System.Drawing.Point(152, 353);
            this.tbNameBook.Name = "tbNameBook";
            this.tbNameBook.Size = new System.Drawing.Size(277, 26);
            this.tbNameBook.TabIndex = 37;
            // 
            // tbArticul
            // 
            this.tbArticul.Enabled = false;
            this.tbArticul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbArticul.Location = new System.Drawing.Point(152, 321);
            this.tbArticul.Name = "tbArticul";
            this.tbArticul.Size = new System.Drawing.Size(277, 26);
            this.tbArticul.TabIndex = 36;
            // 
            // tboxQuality
            // 
            this.tboxQuality.Enabled = false;
            this.tboxQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxQuality.Location = new System.Drawing.Point(152, 630);
            this.tboxQuality.Name = "tboxQuality";
            this.tboxQuality.Size = new System.Drawing.Size(98, 26);
            this.tboxQuality.TabIndex = 56;
            // 
            // tboxSerialsBook
            // 
            this.tboxSerialsBook.Enabled = false;
            this.tboxSerialsBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxSerialsBook.Location = new System.Drawing.Point(151, 538);
            this.tboxSerialsBook.Name = "tboxSerialsBook";
            this.tboxSerialsBook.Size = new System.Drawing.Size(98, 26);
            this.tboxSerialsBook.TabIndex = 57;
            // 
            // numSaleQuantity
            // 
            this.numSaleQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSaleQuantity.Location = new System.Drawing.Point(948, 463);
            this.numSaleQuantity.Name = "numSaleQuantity";
            this.numSaleQuantity.Size = new System.Drawing.Size(82, 26);
            this.numSaleQuantity.TabIndex = 58;
            this.numSaleQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSaleQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnDelSale);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numPrSale);
            this.groupBox1.Controls.Add(this.btnAddSale);
            this.groupBox1.Location = new System.Drawing.Point(798, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 99);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить в акцию";
            // 
            // btnDelSale
            // 
            this.btnDelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelSale.Location = new System.Drawing.Point(248, 26);
            this.btnDelSale.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelSale.Name = "btnDelSale";
            this.btnDelSale.Size = new System.Drawing.Size(100, 45);
            this.btnDelSale.TabIndex = 63;
            this.btnDelSale.Text = "Убрать из акции";
            this.btnDelSale.UseVisualStyleBackColor = true;
            this.btnDelSale.Click += new System.EventHandler(this.btnDelSale_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Процент скидки";
            // 
            // numPrSale
            // 
            this.numPrSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPrSale.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPrSale.Location = new System.Drawing.Point(24, 32);
            this.numPrSale.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numPrSale.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPrSale.Name = "numPrSale";
            this.numPrSale.Size = new System.Drawing.Size(82, 26);
            this.numPrSale.TabIndex = 61;
            this.numPrSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPrSale.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tbNumberOfPages
            // 
            this.tbNumberOfPages.Enabled = false;
            this.tbNumberOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumberOfPages.Location = new System.Drawing.Point(151, 506);
            this.tbNumberOfPages.Name = "tbNumberOfPages";
            this.tbNumberOfPages.Size = new System.Drawing.Size(98, 26);
            this.tbNumberOfPages.TabIndex = 61;
            // 
            // tbGanre
            // 
            this.tbGanre.Enabled = false;
            this.tbGanre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGanre.Location = new System.Drawing.Point(152, 449);
            this.tbGanre.Name = "tbGanre";
            this.tbGanre.Size = new System.Drawing.Size(277, 26);
            this.tbGanre.TabIndex = 62;
            // 
            // btnEditBook
            // 
            this.btnEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditBook.Location = new System.Drawing.Point(904, 585);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(122, 56);
            this.btnEditBook.TabIndex = 63;
            this.btnEditBook.Text = "Редактировать";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnSaveEditBook
            // 
            this.btnSaveEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveEditBook.Location = new System.Drawing.Point(1050, 585);
            this.btnSaveEditBook.Name = "btnSaveEditBook";
            this.btnSaveEditBook.Size = new System.Drawing.Size(122, 56);
            this.btnSaveEditBook.TabIndex = 64;
            this.btnSaveEditBook.Text = "Сохранить Изменения";
            this.btnSaveEditBook.UseVisualStyleBackColor = true;
            this.btnSaveEditBook.Click += new System.EventHandler(this.btnSaveEditBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 668);
            this.Controls.Add(this.btnSaveEditBook);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.tbGanre);
            this.Controls.Add(this.tbNumberOfPages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numSaleQuantity);
            this.Controls.Add(this.tboxSerialsBook);
            this.Controls.Add(this.tboxQuality);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSellingPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Numbername);
            this.Controls.Add(this.tbCostPrice);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbNameBook);
            this.Controls.Add(this.tbArticul);
            this.Controls.Add(this.tboxInputSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxShowSelect);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnSetEdit);
            this.Controls.Add(this.btAddBook);
            this.Controls.Add(this.dgrShowBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrShowBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaleQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrShowBooks;
        private System.Windows.Forms.Button btAddBook;
        private System.Windows.Forms.Button btnSetEdit;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboxShowSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxInputSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSellingPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Numbername;
        private System.Windows.Forms.TextBox tbCostPrice;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbNameBook;
        private System.Windows.Forms.TextBox tbArticul;
        private System.Windows.Forms.TextBox tboxQuality;
        private System.Windows.Forms.TextBox tboxSerialsBook;
        //private System.Windows.Forms.TextBox tboxSelectRow;
        private System.Windows.Forms.NumericUpDown numSaleQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numPrSale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDelSale;
        private System.Windows.Forms.TextBox tbNumberOfPages;
        private System.Windows.Forms.TextBox tbGanre;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnSaveEditBook;
    }
}

