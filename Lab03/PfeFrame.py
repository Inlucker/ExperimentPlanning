import tkinter as tk
from Table import Table
from functions import *
import math
from tkinter import messagebox

class PfeFrame(tk.Frame): 
    def __init__(self, master): 
        super().__init__(master)

        label = tk.Label(self,text="ПФЭ")
        label.grid(column=0)

        self.MainTable = Table(master=self, rows=18, columns=17)
        self.MainTable.grid(column=0, row=1, padx=5, pady=5)

        self.MainTable.set_row(
            0, 
            ['№',"x0", "x1", "x2", "x3", "x4", 
             "x12","x13","x14", "x23", "x24", "x34",  
            "Y", "Yл", "Yчн", "|Y - Yл|", "|Y - Yчн|"]
            )

        self.formula_frame = tk.Frame(
            master=self, 
            highlightbackground="white", 
            highlightthickness=1,background="white")

        self.lin_formula = tk.StringVar()
        self.not_lin_formula = tk.StringVar()
        lin_label = tk.Label(  self.formula_frame, text="Линейная модель: ", background="white")
        lin_label.grid(row=0, column=0, sticky="e")
        lin_formula_label = tk.Label(self.formula_frame, textvariable=self.lin_formula,background="white")
        lin_formula_label.grid(row=0, column=1, sticky="w")

        not_lin_label = tk.Label(self.formula_frame, text="Частично нелинейная модель: ", background="white")
        not_lin_label.grid(row=1, column=0, sticky="e")
        not_lin_formula_label = tk.Label(self.formula_frame, textvariable=self.not_lin_formula, background="white")
        not_lin_formula_label.grid(row=1, column=1, sticky="w")

        self.formula_frame.grid(column=0, row=2)


    def set_x_values(self): 
        for i in range(len(self.x_table)):
            self.MainTable.set_column(i+1, self.x_table[i])

    def modelling(self):
        y = []
        i_lam = (self.gen_int_max1 - self.gen_int_min1) / 2
        lam0 = (self.gen_int_max1 + self.gen_int_min1) / 2
        i_mu = (self.serv_int_max1 - self.serv_int_min1) / 2
        mu0 = (self.serv_int_max1 + self.serv_int_min1) / 2
        
        i_lam2 = (self.gen_int_max2 - self.gen_int_min2) / 2
        lam02 = (self.gen_int_max2 + self.gen_int_min2) / 2
        i_mu2 = (self.serv_int_max2 - self.serv_int_min2) / 2
        mu02 = (self.serv_int_max2 + self.serv_int_min2) / 2
        for i in range(len(self.x_table[0])):
            result = modelling(
                clients_number=self.count+1000,
                clients_proccessed=self.count,
                lambda_coming= self.x_table[1][i] * i_lam + lam0,
                lambda_obr=self.x_table[2][i]* i_mu + mu0, 
                lambda_coming2=self.x_table[3][i] * i_lam2 + lam02,
                lambda_obr2=self.x_table[4][i]* i_mu2 + mu02, 
            )

            y.append(result['wait_time_middle'])
        return y

    def count_one(self, lam, mu, lam2=None, mu2=None):
        #if lam < self.gen_int_min1 or lam > self.gen_int_max1 or mu < self.serv_int_min1 or mu > self.serv_int_max1:
        if lam < self.gen_int_min1 or lam > self.gen_int_max1 or mu < self.serv_int_min1 or mu > self.serv_int_max1 or \
           lam2 < self.gen_int_min2 or lam2 > self.gen_int_max2 or mu2 < self.serv_int_min2 or mu2 > self.serv_int_max2:
            tk.messagebox.showinfo(title="error", message="Точка не входит в промежуток варьирования!")
            return 

        result = modelling(
                clients_number=self.count+1000,
                clients_proccessed=self.count,
                lambda_coming=lam,
                lambda_obr=mu,
                lambda_coming2=lam2 or lam, 
                lambda_obr2=mu2 or mu,
            )

        print(result)
        i_lam = (self.gen_int_max1 - self.gen_int_min1) / 2
        lam0 = (self.gen_int_max1 + self.gen_int_min1) / 2
        i_mu = (self.serv_int_max1 - self.serv_int_min1) / 2
        mu0 = (self.serv_int_max1 + self.serv_int_min1) / 2
        
        i_lam2 = (self.gen_int_max2 - self.gen_int_min2) / 2
        lam02 = (self.gen_int_max2 + self.gen_int_min2) / 2
        i_mu2 = (self.serv_int_max2 - self.serv_int_min2) / 2
        mu02 = (self.serv_int_max2 + self.serv_int_min2) / 2

        x0 = 1

        x1 = (lam - lam0)/i_lam
        x2 = (mu - mu0)/i_mu
        x3 = (lam2  - lam02)/i_lam2
        x4 = (mu2 - mu02)/ i_mu2
        x12 = x1 * x2
        x13 = x1 * x3
        x14 = x1 * x4
        x23 = x2 * x3
        x24 = x2 * x4
        x34 = x3 * x4 
        x123 = x1*x2*x3
        x124 = x1*x2*x4
        x134 = x1*x4*x3
        x234 = x2*x3*x4
        x1234 = x1*x2*x3*x4

        line = ( [x0] + [x1] + [x2] + [x3] + [x4] 
                + [x12] + [x13] + [x14] + [x23] + [x24] + [x34] 
                # + [x123]+[x124]+[x134] +[x234]+[x1234]
                 )

        line2 = ( [x0] + [x1] + [x2] + [x3] + [x4] 
                + [x12] + [x13] + [x14] + [x23] + [x24] + [x34] 
                + [x123]+[x124]+[x134] +[x234]+[x1234]
                 )
        y = result['wait_time_middle']

        s = 0
        l = 5
        for j in range(l): 
            s += line2[j] * self.b[j]
        y_lin = s

        s = 0
        l = len(line2)
        for j in range(l): 
            s += line2[j] * self.b[j]
        y_nl = s

        y_lin_per = abs(y - y_lin)
        y_nl_per = abs(y - y_nl)

        line += [y] + [y_lin] + [y_nl] + [y_lin_per] + [y_nl_per]

        self.MainTable.set_row(17, line, 1)

    def run(self, lambda_min, lambda_max, mu_min, mu_max, count, lambda2_min, lambda2_max, mu2_min, mu2_max):
        self.gen_int_max1 = lambda_max
        self.gen_int_min1 = lambda_min
        self.serv_int_max1 = mu_max
        self.serv_int_min1 = mu_min
        self.gen_int_max2 = lambda2_max
        self.gen_int_min2 = lambda2_min
        self.serv_int_max2 = mu2_max
        self.serv_int_min2 = mu2_min
        self.count = count
        lin_count = 4
        N0 = 2**(lin_count)
        # считаем иксы
        x0 = [1 for i in range(N0)]
        x1 = [1 if i%2==1 else -1 for i in range(N0)]
        x2 = [-1 if i%4 < 2 else 1 for i in range(N0)]
        x3 = [-1 if i%8 < 4 else 1 for i in range(N0)]
        x4 = [-1 if i%16 < 8 else 1 for i in range(N0)]
        x12 = [x1[i]*x2[i] for i in range(len(x1))]
        x13 = [x1[i]*x3[i] for i in range(len(x1))]
        x14 = [x1[i]*x4[i] for i in range(len(x1))]
        x23 = [x2[i]*x3[i] for i in range(len(x2))]
        x24 = [x2[i]*x4[i] for i in range(len(x2))]
        x34 = [x3[i]*x4[i] for i in range(len(x2))]
        x123 = [x1[i]*x2[i]*x3[i] for i in range(len(x1))]
        x124 = [x1[i]*x2[i]*x4[i] for i in range(len(x1))]
        x134 = [x1[i]*x3[i]*x4[i] for i in range(len(x1))]
        x234 = [x2[i]*x3[i]*x4[i] for i in range(len(x2))]
        x1234 = [x1[i]*x2[i]*x3[i]*x4[i] for i in range(len(x2))]

        # отображаем иксы
        for i in range(N0 + 1):
            self.MainTable.set(i+1, 0, i+1)
        self.x_table = [x0] + [x1] + [x2] + [x3] +[x4]+ [x12] + [x13] + [x14] + [x23] + [x24] + [x34]
        self.x_table2 =( [x0] + [x1] + [x2] + [x3] + [x4] 
                        + [x12] + [x13] + [x14] + [x23] + [x24] + [x34] 
                        + [x123] + [x124] + [x134] + [x234] + [x1234] )
        self.set_x_values()

        # print(self.x_table)

        # Считаем игреки
        y = self.modelling()

        # Считаем b
        b = []
        for i in range(len(self.x_table2)):
            b.append(self.count_b(self.x_table2[i], y))
        
        print(b)
        

        # Отображаем игреки и b
        self.MainTable.set_column(12, y)
        self.b = b

        # Считаем линейную и частично не линейную модели
        y_lin = self.count_lin(self.x_table2, b, lin_count+1)
        y_nl = self.count_lin(self.x_table2, b, len(b))
        
        y_lin_per = [abs(y[i] - y_lin[i]) for i in range(len(y))]
        y_nl_per = [abs(y[i] - y_nl[i]) for i in range(len(y))]

        # Отрисовываем
        self.MainTable.set_column( 13, y_lin)
        self.MainTable.set_column(14, y_nl)
        self.MainTable.set_column(15, y_lin_per)
        self.MainTable.set_column(16, y_nl_per)
        self.MainTable.set_row(17, ['','','','','','',
                                    '','','','','','',''], 1)


        lin_str = "y = " + str('{:.5f}'.format(b[0]))
        for i in range (1, lin_count + 1): 
            if (b[i] > 0):
                lin_str += " + " + str('{:.5f}'.format(b[i])) + " * x" + str(i)
            else: 
                lin_str += " - " + str('{:.5f}'.format(math.fabs(b[i]))) + " * x" + str(i)
        
        print(lin_str)
        x_indexes = ["0", "1", "2", "3", "4", 
             "12","13","14", "23", "24", "34", 
             "123","124","134", "234", "1234",]
        not_lin_str = "y = " + str('{:.5g}'.format(b[0]))
        for i in range (1, len(b)):
            if i == round(len(b)/2):
                not_lin_str += '\n' 
            if (b[i] > 0):
                not_lin_str += " + " + str('{:.5g}'.format(b[i])) + " * x" + x_indexes[i]
            else: 
                not_lin_str += " - " + str('{:.5g}'.format(math.fabs(b[i]))) + " * x" + x_indexes[i]
        print(not_lin_str)

        self.lin_formula.set(lin_str)
        self.not_lin_formula.set(not_lin_str)
        
            

    def count_b(self, x, y): 
        sum = 0
        for i in range(len(x)):
            sum += x[i]*y[i]
        return sum/len(x)

    def count_lin(self, x_table, b, l):
        y_lin = []
        for i in range(len(x_table)):
            x = x_table[i] 
            y = 0
            for j in range(l): 
                y += x_table[j][i]*b[j]
            y_lin.append(y)
        return y_lin 