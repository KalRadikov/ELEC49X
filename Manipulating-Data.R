
# Import Work Data & Libraries
library(formattable)
library(gridExtra)
library(plotrix)
library(readxl)
Data <- read_excel("C:/Users/Attila/Desktop/Final Stuff/Our Data/CorrectData.xls",1)
#View(Data)

#################################
### Compare all interests data to "Openness"
#################################

o.cor = data.frame()
o.acor = data.frame()

for (i in 1:60) {
  o.cor[i,1] = cor(Data[,c(6+i)],Data$Openness)
}
# o.cor
o.acor = abs(o.cor)
ranko = order(o.acor,decreasing =T)

# Prints of results
sprintf("The highest correlation for Openness (in decreasing order) is with Q%i, Q%i, Q%i", ranko[1],ranko[2],ranko[3])
check1o = ifelse(sign(o.cor[ranko[1],1])==1,"positively","negatively")
check2o = ifelse(sign(o.cor[ranko[2],1])==1,"positively","negatively")
check3o = ifelse(sign(o.cor[ranko[3],1])==1,"positively","negatively")

sprintf("Where Q%i is %s correlated",ranko[1], check1o)

sprintf("Where Q%i is %s correlated",ranko[2], check2o)

sprintf("Where Q%i is %s correlated",ranko[3], check3o)
sprintf("The lowest correlation for Openness (in increasing order) is with Q%i, Q%i, Q%i", ranko[60],ranko[59],ranko[58])

#################################
### Compare all interests data to "Conscientiousness"
#################################

c.cor = data.frame()
c.acor = data.frame()

for (i in 1:60) {
  c.cor[i,1] = cor(Data[,c(6+i)],Data$Conscientiousness)
}
# c.cor
c.acor = abs(c.cor)
rankc = order(c.acor,decreasing =T)

# Prints of results
sprintf("The highest correlation for Conscientiousness (in decreasing order) is with Q%i, Q%i, Q%i", rankc[1],rankc[2],rankc[3])
check1c = ifelse(sign(c.cor[rankc[1],1])==1,"positively","negatively")
check2c = ifelse(sign(c.cor[rankc[2],1])==1,"positively","negatively")
check3c = ifelse(sign(c.cor[rankc[3],1])==1,"positively","negatively")

sprintf("Where Q%i is %s correlated",rankc[1], check1c)

sprintf("Where Q%i is %s correlated",rankc[2], check2c)

sprintf("Where Q%i is %s correlated",rankc[3], check3c)
sprintf("The lowest correlation for Conscientiousness (in increasing order) is with Q%i, Q%i, Q%i", rankc[60],rankc[59],rankc[58])


#################################
### Compare all interests data to "Extroversion"
#################################

e.cor = data.frame()
e.acor = data.frame()

for (i in 1:60) {
  e.cor[i,1] = cor(Data[,c(6+i)],Data$Extraversion)
}
# e.cor
e.acor = abs(e.cor)
ranke = order(e.acor,decreasing =T)

# Prints of results
sprintf("The highest correlation for Extroversion (in decreasing order) is with Q%i, Q%i, Q%i", ranke[1],ranke[2],ranke[3])
check1e = ifelse(sign(e.cor[ranke[1],1])==1,"positively","negatively")
check2e = ifelse(sign(e.cor[ranke[2],1])==1,"positively","negatively")
check3e = ifelse(sign(e.cor[ranke[3],1])==1,"positively","negatively")

sprintf("Where Q%i is %s correlated",ranke[1], check1e)

sprintf("Where Q%i is %s correlated",ranke[2], check2e)

sprintf("Where Q%i is %s correlated",ranke[3], check3e)
sprintf("The lowest correlation for Extroversion (in increasing order) is with Q%i, Q%i, Q%i", ranke[60],ranke[59],ranke[58])


#################################
### Compare all interests data to "Agreeableness"
#################################

a.cor = data.frame()
a.acor = data.frame()

for (i in 1:60) {
  a.cor[i,1] = cor(Data[,c(6+i)],Data$Agreeableness)
}
# a.cor
a.acor = abs(a.cor)
ranka = order(a.acor,decreasing =T)

# Prints of results
sprintf("The highest correlation for Agreeableness (in decreasing order) is with Q%i, Q%i, Q%i", ranka[1],ranka[2],ranka[3])
check1a = ifelse(sign(a.cor[ranka[1],1])==1,"positively","negatively")
check2a = ifelse(sign(a.cor[ranka[2],1])==1,"positively","negatively")
check3a = ifelse(sign(a.cor[ranka[3],1])==1,"positively","negatively")

sprintf("Where Q%i is %s correlated",ranka[1], check1a)

sprintf("Where Q%i is %s correlated",ranka[2], check2a)

sprintf("Where Q%i is %s correlated",ranka[3], check3a)
sprintf("The lowest correlation for Agreeableness (in increasing order) is with Q%i, Q%i, Q%i", ranka[60],ranka[59],ranka[58])


#################################
### Compare all interests data to "Neuroticism"
#################################

n.cor = data.frame()
n.acor = data.frame()

for (i in 1:60) {
  n.cor[i,1] = cor(Data[,c(6+i)],Data$Neuroticism)
}
# n.cor
n.acor = abs(n.cor)
rankn = order(n.acor,decreasing =T)

# Prints of results
sprintf("The highest correlation for Neuroticism (in decreasing order) is with Q%i, Q%i, Q%i", rankn[1],rankn[2],rankn[3])
check1n = ifelse(sign(n.cor[rankn[1],1])==1,"positively","negatively")
check2n = ifelse(sign(n.cor[rankn[2],1])==1,"positively","negatively")
check3n = ifelse(sign(n.cor[rankn[3],1])==1,"positively","negatively")

sprintf("Where Q%i is %s correlated",rankn[1], check1n)

sprintf("Where Q%i is %s correlated",rankn[2], check2n)

sprintf("Where Q%i is %s correlated",rankn[3], check3n)
sprintf("The lowest correlation for Neuroticism (in increasing order) is with Q%i, Q%i, Q%i", rankn[60],rankn[59],rankn[58])


#########################################################
### Further Analysis - Graphical/Visual Work
#########################################################

### Pie Graphs
################  
# Openess

o.plist = c(o.acor[ranko[1],1],o.acor[ranko[2],1],o.acor[ranko[3],1],o.acor[ranko[4],1],o.acor[ranko[5],1])
o.plist = formattable(o.plist,digits=2,format ="f")
pie3D(o.plist, main = "Openness Correlation Weights",explode = 0.1, labels=o.plist)
legend("topright",c("Q46","Q47","Q51","Q41","Q39"),cex=0.6, fill = rainbow(length(o.plist)))

#Conscientiousness

c.plist = c(c.acor[rankc[1],1],c.acor[rankc[2],1],c.acor[rankc[3],1],c.acor[rankc[4],1],c.acor[rankc[5],1])
c.plist = formattable(c.plist,digits=2,format ="f")
pie3D(c.plist, main = "Conscientiousness Correlation Weights",explode = 0.1, labels=c.plist)
legend("topright",c("Q32","Q40","Q28","Q57","Q6"),cex=0.6, fill = rainbow(length(c.plist)))

#Extroversion

e.plist = c(e.acor[ranke[1],1],e.acor[ranke[2],1],e.acor[ranke[3],1],e.acor[ranke[4],1],e.acor[ranke[5],1])
e.plist = formattable(e.plist,digits=2,format ="f")
pie3D(e.plist, main = "Extroversion Correlation Weights",explode = 0.1, labels=e.plist)
legend("topright",c("Q53","Q54","Q49","Q56","Q8"),cex=0.6, fill = rainbow(length(e.plist)))

#Agreeableness

a.plist = c(a.acor[ranka[1],1],a.acor[ranka[2],1],a.acor[ranka[3],1],a.acor[ranka[4],1],a.acor[ranka[5],1])
a.plist = formattable(a.plist,digits=2,format ="f")
pie3D(a.plist, main = "Agreeableness Correlation Weights",explode = 0.1, labels=a.plist)
legend("topright",c("Q6","Q60","Q43","Q40","Q48"),cex=0.6, fill = rainbow(length(a.plist)))

#Neuroticism

n.plist = c(n.acor[rankn[1],1],n.acor[rankn[2],1],n.acor[rankn[3],1],n.acor[rankn[4],1],n.acor[rankn[5],1])
n.plist = formattable(n.plist,digits=2,format ="f")
pie3D(n.plist, main = "Neuroticism Correlation Weights",explode = 0.1, labels=n.plist)
legend("topright",c("Q20","Q57","Q55","Q60","Q59"),cex=0.6, fill = rainbow(length(n.plist)))

### Bar Graph
# Correlation vs OCEAN
###########################

O= c(o.acor[ranko[1],1],o.acor[ranko[2],1],o.acor[ranko[3],1])
C = c(c.acor[rankc[1],1],c.acor[rankc[2],1],c.acor[rankc[3],1])
E = c(e.acor[ranke[1],1],e.acor[ranke[2],1],e.acor[ranke[3],1])
A = c(a.acor[ranka[1],1],a.acor[ranka[2],1],a.acor[ranka[3],1])
N = c(n.acor[rankn[1],1],n.acor[rankn[2],1],n.acor[rankn[3],1])
T.hist = cbind(O,C,E,A,N)
barplot(T.hist,beside=T,main = "Top Correlations vs. OCEAN",ylab = "Correlation Strength",ylim=c(0,0.6),col=c("#00008B","#FFB90F","#8B0000"))
legend("topright",c("Rank 1","Rank 2","Rank 3"),cex=0.6,fill= c("#00008B","#FFB90F","#8B0000"))


## Principal Component Analysis
################################
#Openness

o1 = Data[,2]
o2 = Data[,6+ranko[1]]
o3 = Data[,6+ranko[2]]
o4 = Data[,6+ranko[3]]
PCo = cbind(o1,o2,o3,o4)

pr.out=prcomp(PCo, scale=TRUE)
graphics.off()
grid.table(pr.out$rotation)
biplot(pr.out, scale=0,main= "PCA of Openness")

pr.out$sdev
pr.var=pr.out$sdev^2
pve=pr.var/sum(pr.var)
plot(pve,main= "Proportion of Variance for Openness", xlab="Principal Component", ylab="Proportion of Variance Explained", ylim=c(0,1),type='b')

# Conscientiousness

c1 = Data[,3]
c2 = Data[,6+rankc[1]]
c3 = Data[,6+rankc[2]]
c4 = Data[,6+rankc[3]]
PCc = cbind(c1,c2,c3,c4)

pr.out=prcomp(PCc, scale=TRUE)
graphics.off()
grid.table(pr.out$rotation)
biplot(pr.out, scale=0,main= "PCA of Conscientiousness")

pr.var=pr.out$sdev^2
pve=pr.var/sum(pr.var)
plot(pve,main= "Proportion of Variance for Conscientiousness", xlab="Principal Component", ylab="Proportion of Variance Explained", ylim=c(0,1),type='b')

# Extroversion

e1 = Data[,4]
e2 = Data[,6+ranke[1]]
e3 = Data[,6+ranke[2]]
e4 = Data[,6+ranke[3]]
PCe = cbind(e1,e2,e3,e4)

pr.out=prcomp(PCe, scale=TRUE)
graphics.off()
grid.table(pr.out$rotation)
biplot(pr.out, scale=0,main= "PCA of Extroversion")

pr.var=pr.out$sdev^2
pve=pr.var/sum(pr.var)
plot(pve,main= "Proportion of Variance for Extroversion", xlab="Principal Component", ylab="Proportion of Variance Explained", ylim=c(0,1),type='b')

# Agreeableness

a1 = Data[,5]
a2 = Data[,6+ranka[1]]
a3 = Data[,6+ranka[2]]
a4 = Data[,6+ranka[3]]
PCa = cbind(a1,a2,a3,a4)

pr.out=prcomp(PCa, scale=TRUE)
graphics.off()
grid.table(pr.out$rotation)
biplot(pr.out, scale=0,main= "PCA of Agreeableness")

pr.var=pr.out$sdev^2
pve=pr.var/sum(pr.var)
plot(pve,main= "Proportion of Variance for Agreeableness", xlab="Principal Component", ylab="Proportion of Variance Explained", ylim=c(0,1),type='b')

# Neuroticism

n1 = Data[,6]
n2 = Data[,6+rankn[1]]
n3 = Data[,6+rankn[2]]
n4 = Data[,6+rankn[3]]
PCn = cbind(n1,n2,n3,n4)

pr.out=prcomp(PCn, scale=TRUE)
graphics.off()
grid.table(pr.out$rotation)
biplot(pr.out, scale=0,main= "PCA of Neuroticism")

pr.var=pr.out$sdev^2
pve=pr.var/sum(pr.var)
plot(pve,main= "Proportion of Variance for Neuroticism", xlab="Principal Component", ylab="Proportion of Variance Explained", ylim=c(0,1),type='b')


#########################################################
### Unused Graphs, but kept just incase
#########################################################


### Histogram - One big one
# Correlation vs OCEAN
###########################

o.hist = c(o.acor[ranko[1],1],o.acor[ranko[2],1],o.acor[ranko[3],1])
c.hist = c(c.acor[rankc[1],1],c.acor[rankc[2],1],c.acor[rankc[3],1])
e.hist = c(e.acor[ranke[1],1],e.acor[ranke[2],1],e.acor[ranke[3],1])
a.hist = c(a.acor[ranka[1],1],a.acor[ranka[2],1],a.acor[ranka[3],1])
n.hist = c(n.acor[rankn[1],1],n.acor[rankn[2],1],n.acor[rankn[3],1])
T.hist = c(o.hist,c.hist,e.hist,a.hist,n.hist)
hist(T.hist)












