alter table PlayerTable add constraint PlayerTable_TeamTable_FK FOREIGN KEY ( Team ) references TeamTable(TeamID) 
--alter table TeamTable add constraint PlayerTable_TeamTable_FK FOREIGN KEY ( TeamID ) references PlayerTable( Team )

--select DISTINCT PT.Team, TT.TeamID
--  from dbo.playertable PT
--  FULL OUTER JOIN dbo.teamtable TT
--    ON PT.Team = TT.TeamID

-- where pt.team is null
--    or tt.teamid is null



