% In the name of ALLAH
%
% This program is associated to "Windy-Grid" Project
%   A Program to draw the graphs of Algorithms' Exported Data

%   Thanks to our professor: Dr. Bagherzadeh
%   Programmer: Ali Asghar Bastanfar
%   1389 (2011) - Iran
% -------------------------------------------------------------------------

clc;

[rows,c] = size(Data);
sum1 = 0;
sum2 = 0;
sum3 = 0;

for i=1:rows
    sum1 = sum1 + Data(i,1);
    Aggregated(i,1) = sum1;
    
    sum2 = sum2 + Data(i,2);
    Aggregated(i,2)  = sum2;
    
    sum3 = sum3 + Data(i,3);
    Aggregated(i,3) = sum3;
end

episode(:,1) = 1:rows;

disp('Windy-Grid Project');
key = input('Press any key to Draw Graph');

hold off;
plot( Aggregated(:,1) , episode(:,1), 'r',  Aggregated(:,2) , episode(:,1), 'b',   Aggregated(:,3) , episode(:,1), 'g')
title('Results of Algorithms on Windy-Grid Project','FontSize',12);
legend('Monte Carlo','Sarsa','Q-Learning');
grid;
hold off;
xlabel('Time Steps');
ylabel('Episodes');


key = input('Press any key to continue ...');
plot(episode(1:1000,1), Data(1:1000,1),'r', episode(1:1000,1), Data(1:1000,2),'b', episode(1:1000,1), Data(1:1000,3),'g');
title('Length of each episode for first 1000 episodes','FontSize',12);
legend('Monte Carlo','Sarsa','Q-Learning');
xlabel('Episode');
ylabel('Length (State)');

