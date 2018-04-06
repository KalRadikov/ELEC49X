# Put data into R
col <- read.csv("columns.csv", header = TRUE)
res <- read.csv("responses.csv", header = TRUE)

# Create new frame of hobby data
music <- data.frame(PersonID = rep(1:nrow(res)), res[,1:19])
movies <- data.frame(PersonID = rep(1:nrow(res)), res[,20:31])
hobbies <- data.frame(PersonID = rep(1:nrow(res)), res[,32:63])
phobias <- data.frame(PersonID = rep(1:nrow(res)), res[,64:73])
health <- data.frame(PersonID = rep(1:nrow(res)), res[,74:76])
personal <- data.frame(PersonID = rep(1:nrow(res)), res[,77:133])
spending <- data.frame(PersonID = rep(1:nrow(res)), res[,134:140])
demog <- data.frame(PersonID = rep(1:nrow(res)), res[,141:150])

########################################################################### Try 1

#Check the value types
str(hobbies)
hobbies[2:33] <- lapply(hobbies[2:33], factor)
str(hobbies)

#find unique ages
unique(demog$Age)
# differentiate by age range, 16-19, 20-23, 24-27, 27-30
teens <- demog[which(demog$Age >= 16 & demog$Age <= 19),]
e.twent <- demog[which(demog$Age >= 20 & demog$Age <= 23),]
m.twent <- demog[which(demog$Age >= 24 & demog$Age <= 27),]
l.twent <- demog[which(demog$Age >= 28 & demog$Age <= 30),]

library(plyr)
hobbies.teen <- hobbies[which(demog$Age >=16 & demog$Age <=19),]
teens.hob <- cbind(teens, hobbies.teen)
teens.hob <- teens.hob[, !duplicated(colnames(teens.hob))]
str(teens.hob$Age)
teens.hob$Age <- as.factor(teens.hob$Age)

library(ggplot2)
library(scales)

# Want to find hobbies liked by age
ggplot(teens.hob, aes (x = Age, fill = factor(History))) +
  stat_count(width = 0.5)  +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest") 
# + scale_y_continuous(labels = percent)

#####################################################################
#                                                                   #
#                       Multi Plot Function                         #
#                                                                   #
#####################################################################


multiplot <- function(..., plotlist=NULL, file, cols=1, layout=NULL) {
  library(grid)
  
  # Make a list from the ... arguments and plotlist
  plots <- c(list(...), plotlist)
  
  numPlots = length(plots)
  
  # If layout is NULL, then use 'cols' to determine layout
  if (is.null(layout)) {
    # Make the panel
    # ncol: Number of columns of plots
    # nrow: Number of rows needed, calculated from # of cols
    layout <- matrix(seq(1, cols * ceiling(numPlots/cols)),
                     ncol = cols, nrow = ceiling(numPlots/cols))
  }
  
  if (numPlots==1) {
    print(plots[[1]])
    
  } else {
    # Set up the page
    grid.newpage()
    pushViewport(viewport(layout = grid.layout(nrow(layout), ncol(layout))))
    
    # Make each plot, in the correct location
    for (i in 1:numPlots) {
      # Get the i,j matrix positions of the regions that contain this subplot
      matchidx <- as.data.frame(which(layout == i, arr.ind = TRUE))
      
      print(plots[[i]], vp = viewport(layout.pos.row = matchidx$row,
                                      layout.pos.col = matchidx$col))
    }
  }
}


#####################################################################
## Manipulating Data to Percentages
#####################################################################
test <- teens[,1:4]
str(test)
test$Age <- as.factor(test$Age)
str(test)
test$Age <- as.integer(levels(test$Age))[test$Age]
str(test)


hob.age$Age <- as.integer(levels(hob.age$Age))[hob.age$Age]
str(hob.age$Age)
length(which(hob.age$Age == 16))
length(which(hob.age$History == 5 & hob.age$Age == 16))
length(which(hob.age$History == 4 & hob.age$Age == 16))
length(which(hob.age$History == 3 & hob.age$Age == 16))
length(which(hob.age$History == 2 & hob.age$Age == 16))
length(which(hob.age$History == 1 & hob.age$Age == 16))


##################################################################### WORKS! Finding Percent

p.history <- data.frame(Age = rep(15,5),Subject = rep(1:5,1),Interest = rep(0,5))
for(i in 1:15) {
  p.history <- rbind(p.history,data.frame(Age = rep(15+i,5),Subject = rep(1:5,1),Interest = rep(0,5)))
}

for(i in 1:16) {
  for(j in 1:5) {
    p.history[j+5*(i-1),3] <- (1/length(which(hob.age$Age == 14+i)))*length(which(hob.age$History == j & hob.age$Age == 14+i))
  }
}  

ggplot(p.history, aes (x = Age, fill = factor(Subject),weight = Interest)) +
  geom_bar(width = 0.5)  +
  ggtitle("History") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest") 

#####################################################################
##   GRAPHING DATA
#####################################################################

hob.age <- cbind(demog, hobbies)
hob.age <- hob.age[, !duplicated(colnames(hob.age))]
hob.age <- cbind(hob.age,data.frame(Interest = rep(0,1010)))


# Finding Weights of All
for(i in 1:1010){
  if(is.na(hob.age[i,2])) {
    hob.age[i,44] <- 0
  }else if(hob.age[i,2] == 15) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 15)))
  }else if(hob.age[i,2] == 16) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 16)))
  }else if(hob.age[i,2] == 17) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 17)))
  }else if(hob.age[i,2] == 18) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 18)))
  }else if(hob.age[i,2] == 19) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 19)))
  }else if(hob.age[i,2] == 20) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 20)))
  }else if(hob.age[i,2] == 21) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 21)))
  }else if(hob.age[i,2] == 22) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 22)))
  }else if(hob.age[i,2] == 23) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 23)))
  }else if(hob.age[i,2] == 24) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 24)))
  }else if(hob.age[i,2] == 25) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 25)))
  }else if(hob.age[i,2] == 26) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 26)))
  }else if(hob.age[i,2] == 27) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 27)))
  }else if(hob.age[i,2] == 28) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 28)))
  }else if(hob.age[i,2] == 29) {
    hob.age[i,44] <- (1/length(which(hob.age$Age == 29)))
  }else if(hob.age[i,2] == 30) {
      hob.age[i,44] <- (1/length(which(hob.age$Age == 30)))
  }else {
    hob.age[i,44] <- 0
  }
}


t1 <- ggplot(hob.age, aes (x = Age, fill = factor(History))) +
  stat_count(width = 0.5)  +
  ggtitle("History") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")


t2 <- ggplot(hob.age, aes (x = Age, fill = factor(History), weight = Interest )) +
  stat_count(width = 0.5)  +
  ggtitle("History") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest") +
  scale_y_continuous(labels = percent)

multiplot(t1, t2, cols=2)

p1 <- ggplot(hob.age, aes (x = Age, fill = factor(History))) +
    stat_count(width = 0.5)  +
    ggtitle("History") +
    xlab("Age") +
    ylab("Total Count") +
    labs(fill = "Interest")
p2 <- ggplot(hob.age, aes (x = Age, fill = factor(Psychology))) +
  stat_count(width = 0.5)  +
  ggtitle("Psychology") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")
p3 <- ggplot(hob.age, aes (x = Age, fill = factor(Politics))) +
  stat_count(width = 0.5)  +
  ggtitle("Politics") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")
p4 <- ggplot(hob.age, aes (x = Age, fill = factor(Mathematics))) +
  stat_count(width = 0.5)  +
  ggtitle("Mathematics") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")
p5 <- ggplot(hob.age, aes (x = Age, fill = factor(Physics))) +
  stat_count(width = 0.5)  +
  ggtitle("Physics") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")
p6 <- ggplot(hob.age, aes (x = Age, fill = factor(Internet))) +
  stat_count(width = 0.5)  +
  ggtitle("Internet") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")
p7 <- ggplot(hob.age, aes (x = Age, fill = factor(PC))) +
  stat_count(width = 0.5)  +
  ggtitle("PC") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")
p8 <- ggplot(hob.age, aes (x = Age, fill = factor(Economy.Management))) +
  stat_count(width = 0.5)  +
  ggtitle("Economy Management") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")
p9 <- ggplot(hob.age, aes (x = Age, fill = factor(Biology))) +
  stat_count(width = 0.5)  +
  ggtitle("Biology") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")
p10 <- ggplot(hob.age, aes (x = Age, fill = factor(Chemistry))) +
  stat_count(width = 0.5)  +
  ggtitle("Chemistry") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")
p11 <- ggplot(hob.age, aes (x = Age, fill = factor(Reading))) +
  stat_count(width = 0.5)  +
  ggtitle("Reading") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")
p12 <- ggplot(hob.age, aes (x = Age, fill = factor(Geography))) +
  stat_count(width = 0.5)  +
  ggtitle("Geography") +
  xlab("Age") +
  ylab("Total Count") +
  labs(fill = "Interest")


multiplot(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, cols=4)


#####################################################################
