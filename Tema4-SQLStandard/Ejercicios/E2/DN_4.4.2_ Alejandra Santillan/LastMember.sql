select max(membershiptypes.idmembershiptypes) as 'Registration Id' ,members.name as 'Last Member', membershiptypes.name as 'Membershiptype Name'
  from members
  inner join membershiptypes on membershiptypes.idmembershiptypes = members.idmembershiptypes
  