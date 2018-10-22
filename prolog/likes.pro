%% likes knowledge base

indian(curry).
indian(dahl).
indian(tandoori).
indian(kurma).
indian(naan).

mild(dahl).
mild(tandoori).
mild(kurma).

chinese(chow_mein).
chinese(chop_suey).
chinese(sweet_and_sour).

italian(pizza).
italian(spaghetti).
italian(lasagna).

likes(sam, chips).

likes(sam,Food) :- indian(Food), mild(Food).
likes(sam,Food) :- italian(Food).

