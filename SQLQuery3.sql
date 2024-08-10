create view InfoTransfer AS
SELECT TransferLogs.DateTime,
                      (SELECT FirstName + ' ' + LastName AS SAcct
                       FROM      Persons
                       WHERE   (PersonID =
                                             (SELECT DISTINCT PersonID
                                              FROM      Clients
                                              WHERE   (ClientID = Transfers.ClientID)))) AS SAcct,
                      (SELECT FirstName + ' ' + LastName AS DAcct
                       FROM      Persons AS Persons_2
                       WHERE   (PersonID =
                                             (SELECT DISTINCT PersonID
                                              FROM      Clients AS Clients_2
                                              WHERE   (ClientID = Transfers.ClientID2)))) AS DAcct, TransferLogs.Amount,
                      (SELECT Balance
                       FROM      Clients
                       WHERE   (ClientID = Transfers.ClientID)) AS SBalance,
                      (SELECT Balance
                       FROM      Clients
                       WHERE   (ClientID = Transfers.ClientID2)) AS DBalance,
                      (SELECT FirstName + ' ' + LastName AS SAcct
                       FROM      Persons
                       WHERE   (PersonID =
                                             (SELECT PersonID
                                              FROM      Users
                                              WHERE   (UserID = Transfers.UserID)))) AS UserName
FROM     Transfers INNER JOIN
                  TransferLogs ON Transfers.TransferLogID = TransferLogs.TransferLogID