using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodLibrary.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "DishDescription", "DishName", "Ingredients" },
                values: new object[,]
                {
                    { 1, "Bamboo skewers loaded with buffalo and venison", "Buffalo and venison skewers", "onions | buffalo | venison" },
                    { 2, "Fresh kumquat and rye served on a bed of lettuce", "Kumquat and rye salad", "lettuce | kumquat | rye" },
                    { 3, "A crunchy salad featuring gruyere and granola", "Gruyere and granola salad", "cress | tomato | white cabbage | gruyere | granola" },
                    { 4, "Salami and fresh sage served on a bed of lettuce", "Salami and sage salad", "lettuce | salami | sage" },
                    { 5, "A warm, pressed panini filled with crayfish and smoked turkey", "Crayfish and turkey panini", "flour | yeast | water | salt | sugar | oil | crayfish | turkey" },
                    { 6, "A crisp salad featuring fresh cauliflower and butterbean", "Cauliflower and butterbean salad", "tomato | lettuce | cucumber | cauliflower | butterbean" },
                    { 7, "A puff pasty case filled with fresh garlic and potato", "Garlic and potato pie", "flour | butter | water | salt | onions | garlic | potato" },
                    { 8, "Fresh egg tubular pasta in a sauce made from dolcelatte and tubetti", "Dolcelatte and tubetti penne", "tomato | onion | garlic | pasta | oregano | black pepper | dolcelatte | tubetti" },
                    { 9, "Minced lamb and pigeon stewed", "Lamb and pigeon casserole", "onion | salt | black pepper | potatoes | lamb | pigeon" },
                    { 10, "Thin wonton cases stuffed with garam masala and smoked cheese", "Garam masala and cheese wontons", "flour | water | salt | onions | garam masala | cheese" },
                    { 11, "Thin pastry cases stuffed with baby leek and fresh horseradish", "Leek and horseradish gyoza", "flour | water | salt | onions | leek | horseradish" },
                    { 12, "A crisp salad featuring coconut milk and caviar", "Coconut milk and caviar salad", "tomato | white cabbage | cucumber | coconut milk | caviar" },
                    { 13, "A hot, pressed panini filled with baby onion and corn-fed chicken", "Onion and chicken panini", "flour | yeast | water | salt | sugar | oil | onion | chicken" },
                    { 14, "A crisp salad featuring cumin seeds and fresh loquat", "Cumin seed and loquat salad", "cucumber | white cabbage | tomato | cumin seed | loquat" },
                    { 15, "Fish and butternut squash stewed", "Fish and squash stew", "onion | salt | black pepper | potatoes | fish | squash" },
                    { 16, "Tumeric and chinese cabbage served on a bed of lettuce", "Tumeric and cabbage salad", "lettuce | tumeric | cabbage" },
                    { 17, "A crunchy salad featuring fresh mangetout and blackberry", "Mangetout and blackberry salad", "tomato | lettuce | cucumber | mangetout | blackberry" },
                    { 18, "Spicy vindaloo made with crushed black pepper and fresh squash", "Black pepper and squash vindaloo", "onion | peppers | garlic | ginger | tumeric | cumin | coriander | black pepper | mustard seeds | cardamon | cinnamon | white wine vinegar | cayenne | squash" },
                    { 19, "Lea bacon and socca served on a bed of lettuce", "Bacon and socca salad", "lettuce | bacon | socca" },
                    { 20, "Thin wonton cases stuffed with scallop and rainbow trout", "Scallop and trout wontons", "flour | water | salt | sugar | scallop | trout" },
                    { 21, "A crunchy salad featuring italian seasoning and caraway seeds", "Italian seasoning and caraway seed salad", "tomato | lettuce | white cabbage | italian seasoning | caraway seed" },
                    { 22, "Thin pastry cases stuffed with fresh celeriac and pigeon", "Celeriac and pigeon dumplings", "flour | water | salt | onions | celeriac | pigeon" },
                    { 23, "Thin pastry cases stuffed with garam masala and crab", "Garam masala and crab dumplings", "flour | water | salt | onions | garam masala | crab" },
                    { 24, "Mild curry made with creamed sweetcorn and fresh banana", "Sweetcorn and banana curry", "onion | peppers | garlic | ginger | tumeric | cumin | coriander | curry leaf | green chilli | sweetcorn | banana" },
                    { 25, "Spagetti topped with a blend of fresh cheese and tangy feta", "Cheese and feta spaghetti", "tomato | passata | onion | garlic | spagetti | oregano | black pepper | cheese | feta" },
                    { 26, "Bamboo skewers loaded with marinaded tofu and smoked turkey", "Tofu and turkey skewers", "onions | tofu | turkey" },
                    { 27, "Spicy vindaloo made with pacific cod and fresh anise", "Cod and anise vindaloo", "onion | peppers | garlic | ginger | tumeric | cumin | coriander | black pepper | mustard seeds | cardamon | cinnamon | white wine vinegar | cayenne | cod | anise" },
                    { 28, "Warm ciabatta filled with grouse and fish", "Grouse and fish ciabatta", "flour | yeast | water | salt | sugar | oil | grouse | fish" },
                    { 29, "Nutritional yeast and fresh broccoli served on a bed of lettuce", "Nutritional yeast and broccoli salad", "lettuce | nutritional yeast | broccoli" },
                    { 30, "Sizzling sausages made from black peppercorn and fresh cranberries, served in a roll", "Peppercorn and cranberry sausages", "flour | yeast | water | salt | sugar | oil | onions | peppercorn | cranberry" },
                    { 31, "Thin pastry cases stuffed with mixed peppercorn and chinese cabbage", "Peppercorn and cabbage gyoza", "flour | water | salt | onions | peppercorn | cabbage" },
                    { 32, "A crunchy salad featuring prosciutto and garlic oil", "Prosciutto and garlic oil salad", "tomato | lettuce | white cabbage | prosciutto | garlic oil" },
                    { 33, "Thin and crispy pizza topped with fresh mozzarella and creamy cheese", "Mozzarella and cheese pizza", "flour | yeast | water | salt | sugar | oil | cheese | mozzarella" },
                    { 34, "A crunchy salad featuring fresh daikon and seville orange", "Daikon and orange salad", "cress | white cabbage | cucumber | daikon | orange" },
                    { 35, "Thin pastry cases stuffed with red pesto and smoked salmon", "Pesto and salmon dumplings", "flour | water | salt | onions | pesto | salmon" },
                    { 36, "Spicy vindaloo made with fresh rambutan and goat", "Rambutan and goat vindaloo", "onion | peppers | garlic | ginger | tumeric | cumin | coriander | black pepper | mustard seeds | cardamon | cinnamon | white wine vinegar | cayenne | rambutan | goat" },
                    { 37, "Crunchy stir fry featuring fresh quinoa and courgette", "Quinoa and courgette stir fry", "garlic | quinoa | courgette" },
                    { 38, "Fresh egg tubular pasta in a sauce made from stilton and smoked pancetta", "Stilton and pancetta penne", "tomato | onion | garlic | pasta | oregano | black pepper | stilton | pancetta" },
                    { 39, "Succulent burgers made from corn-fed chicken and beef, served in a roll", "Chicken and beef burgers", "flour | yeast | water | salt | sugar | oil | onions | chicken | beef" },
                    { 40, "Fresh egg tubular pasta in a sauce made from freshly-caught salmon and fresh avocado", "Salmon and avocado penne", "tomato | onion | garlic | pasta | oregano | black pepper | salmon | avocado" },
                    { 41, "Medium-hot madras made with fresh mango and hot black pepper", "Mango and black pepper madras", "onion | peppers | garlic | ginger | tumeric | cumin | coriander | red chilli | tomato | mango | black pepper" },
                    { 42, "Hot slices of bread filled with hot black pepper and silken tofu", "Black pepper and tofu toastie", "flour | yeast | water | salt | sugar | oil | black pepper | tofu" }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "DishDescription", "DishName", "Ingredients" },
                values: new object[,]
                {
                    { 43, "Fresh egg pasta in a sauce made from fresh lobster and chunky sausage", "Lobster and sausage fusilli", "tomato | onion | garlic | pasta | oregano | black pepper | lobster | sausage" },
                    { 44, "Spicy curry made with bell pepper and navratan", "Pepper and navratan curry", "onion | peppers | garlic | ginger | tumeric | cumin | coriander | curry leaf | green chilli | pepper | navratan" },
                    { 45, "Bamboo skewers loaded with duck and fresh mangetout", "Duck and mangetout skewers", "onions | duck | mangetout" },
                    { 46, "Hot vindaloo made with tumeric and asafoetida", "Tumeric and asafoetida vindaloo", "onion | peppers | garlic | ginger | tumeric | cumin | coriander | black pepper | mustard seeds | cardamon | cinnamon | white wine vinegar | cayenne | asafoetida" },
                    { 47, "Creamy risotto rice with gorgonzola and scallop", "Gorgonzola and scallop risotto", "olive oil | onion | garlic | spring onions | rice | cumin | parmesan | gorgonzola | scallop | cream" },
                    { 48, "Seaweed and gammon served on a bed of lettuce", "Seaweed and gammon salad", "lettuce | seaweed | gammon" },
                    { 49, "Warm ciabatta filled with fresh banana and yellow grapefruit", "Banana and grapefruit ciabatta", "flour | yeast | water | salt | sugar | oil | banana | grapefruit" },
                    { 50, "Fresh egg pasta in a sauce made from dolcelatte and lea bacon", "Dolcelatte and bacon pasta", "tomato | onion | garlic | pasta | oregano | black pepper | dolcelatte | bacon" },
                    { 51, "Spagetti topped with a blend of bresaola and fresh broccoli", "Bresaola and broccoli spaghetti", "tomato | passata | onion | garlic | spagetti | oregano | black pepper | bresaola | broccoli" },
                    { 52, "A warm bagel filled with bell pepper and steak", "Pepper and steak bagel", "flour | yeast | water | salt | sugar | oil | pepper | steak" },
                    { 53, "Smoked turkey and minced lamb stewed", "Turkey and lamb stew", "onion | salt | black pepper | potatoes | turkey | lamb" },
                    { 54, "Black mustard seeds and dried chilli served on a bed of lettuce", "Mustard seed and chilli salad", "lettuce | mustard seed | chilli" },
                    { 55, "Crisp slices of bread filled with corn-fed chicken and fresh avocado", "Chicken and avocado toastie", "flour | yeast | water | salt | sugar | oil | chicken | avocado" },
                    { 56, "Thin wonton cases stuffed with crisp apple and green cardamom", "Apple and cardamom wontons", "flour | water | salt | sugar | apple | cardamom" },
                    { 57, "A shortcrust pasty case filled with mature cheese and beef", "Cheese and beef pie", "flour | butter | water | salt | sugar | cheese | beef" },
                    { 58, "Fluffy bread made with sea salt and cinnamon", "Salt and cinnamon bread", "flour | salt | yeast | butter | water | onions | cinnamon" },
                    { 59, "A crunchy salad featuring fresh spring onion and frangelico", "Spring onion and frangelico salad", "cucumber | tomato | white cabbage | spring onion | frangelico" },
                    { 60, "A crisp salad featuring bean and cashew", "Bean and cashew salad", "cucumber | lettuce | cress | bean | cashew" },
                    { 61, "Skewer-cooked streaky bacon and smoked turkey served in warm pitta pockets", "Bacon and turkey kebab", "onions | flour | yeast | water | salt | sugar | oil | bacon | turkey" },
                    { 62, "Thin and crispy pizza topped with polenta and smoked ham", "Polenta and ham pizza", "flour | yeast | water | salt | sugar | oil | cheese | polenta | ham" },
                    { 63, "Fresh egg pasta in a sauce made from caper and tangy lemon", "Caper and lemon pasta", "tomato | onion | garlic | pasta | oregano | black pepper | caper | lemon" },
                    { 64, "Fresh egg pasta in a sauce made from sun-dried tomato pesto and minced lamb", "Pesto and lamb pasta", "tomato | onion | garlic | pasta | oregano | black pepper | pesto | lamb" },
                    { 65, "Creamy korma made with fresh cauliflower and dried mango", "Cauliflower and mango korma", "onion | peppers | garlic | ginger | tumeric | cumin | coriander | butter | sugar | cream | cauliflower | mango" },
                    { 66, "Hot slices of bread filled with crayfish and crispy tofu", "Crayfish and tofu toastie", "flour | yeast | water | salt | sugar | oil | crayfish | tofu" },
                    { 67, "Bamboo skewers loaded with baby new potato and minced lamb", "Potato and lamb skewers", "onions | potato | lamb" },
                    { 68, "Swordfish and tangy feta served on a bed of lettuce", "Swordfish and feta salad", "lettuce | swordfish | feta" },
                    { 69, "Mild korma made with minced lamb and fresh cod", "Lamb and cod korma", "onion | peppers | garlic | ginger | tumeric | cumin | coriander | butter | sugar | cream | lamb | cod" },
                    { 70, "Thin and crispy pizza topped with fresh marjoram and tuna", "Marjoram and tuna pizza", "flour | yeast | water | salt | sugar | oil | cheese | marjoram | tuna" },
                    { 71, "A flaky pasty case filled with crisp apple and wild rice", "Apple and rice pie", "flour | butter | water | salt | onions | apple | rice" },
                    { 72, "A crisp salad featuring goose and green cabbage", "Goose and green cabbage salad", "white cabbage | tomato | lettuce | goose | green cabbage" },
                    { 73, "Fluffy bread made with polenta and creamy butter", "Polenta and butter loaf", "flour | salt | yeast | butter | water | onions | polenta" },
                    { 74, "Pectin and ragu served on a bed of lettuce", "Pectin and ragu salad", "lettuce | pectin | ragu" },
                    { 75, "Pasta in a sauce made from fresh avocado and red pepper", "Avocado and pepper uramaki", "rice | rice vinegar | sugar | avocado | pepper" },
                    { 76, "Shitake mushroom and olive stewed", "Mushroom and olive stew", "onion | salt | black pepper | potatoes | mushroom | olive" },
                    { 77, "A crisp salad featuring creole seasoning and boar", "Creole seasoning and boar salad", "lettuce | tomato | cucumber | creole seasoning | boar" },
                    { 78, "Skewer-cooked smoked tofu and duck served in warm pitta pockets", "Tofu and duck kebab", "flour | yeast | water | salt | sugar | oil | tofu | duck" },
                    { 79, "A crunchy salad featuring radiatori and flaxseeds", "Radiatori and flaxseed salad", "tomato | lettuce | cucumber | radiatori | flaxseed" },
                    { 80, "Fresh lemon and celery combined into smooth soup", "Lemon and celery soup", "garlic | lemon | celery" },
                    { 81, "Mild korma made with fresh plantain and duck", "Plantain and duck korma", "onion | peppers | garlic | ginger | tumeric | cumin | coriander | butter | sugar | cream | plantain | duck" },
                    { 82, "Stem ginger and fresh celery stewed", "Ginger and celery casserole", "onion | salt | black pepper | potatoes | ginger | celery" },
                    { 83, "Fresh cranberries and cajun seasoning served on a bed of lettuce", "Cranberry and cajun seasoning salad", "lettuce | cranberry | cajun seasoning" },
                    { 84, "Crunchy bread made with creamy cheese and fresh raisin", "Cheese and raisin bread", "flour | salt | yeast | butter | water | onions | cheese | raisin" }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "DishDescription", "DishName", "Ingredients" },
                values: new object[,]
                {
                    { 85, "A crisp salad featuring goosnargh and sharon fruit", "Goosnargh and sharon fruit salad", "cress | white cabbage | lettuce | goosnargh | sharon fruit" },
                    { 86, "Crunchy stir fry featuring fresh wasabi and mangetout", "Wasabi and mangetout stir fry", "garlic | wasabi | mangetout" },
                    { 87, "Root ginger and shrimp combined into chunky soup", "Ginger and shrimp soup", "onion | ginger | shrimp" },
                    { 88, "Crunchy stir fry featuring spiced pumpkin and fresh chickpea", "Pumpkin and chickpea stir fry", "garlic | pumpkin | chickpea" },
                    { 89, "A warm bagel filled with pork and fresh cucumber", "Pork and cucumber bagel", "flour | yeast | water | salt | sugar | oil | pork | cucumber" },
                    { 90, "Crunchy bread made with tea and fresh yeast", "Tea and yeast bread", "flour | salt | yeast | butter | water | onions | tea" },
                    { 91, "Garlic powder and fresh star fruit served on a bed of lettuce", "Garlic powder and star fruit salad", "lettuce | garlic powder | star fruit" },
                    { 92, "Thin wonton cases stuffed with fresh jalapeno and hot chilli", "Jalapeno and chilli wontons", "flour | water | salt | onions | jalapeno | chilli" },
                    { 93, "Warm ciabatta filled with fresh jalapeno and cucumber", "Jalapeno and cucumber ciabatta", "flour | yeast | water | salt | sugar | oil | jalapeno | cucumber" },
                    { 94, "Turbot and serrano ham served on a bed of lettuce", "Turbot and serrano ham salad", "lettuce | turbot | serrano ham" },
                    { 95, "A crisp salad featuring caramel sauce and gorgonzola", "Caramel sauce and gorgonzola salad", "cress | tomato | cucumber | caramel sauce | gorgonzola" },
                    { 96, "A crunchy salad featuring parma ham and samphire", "Parma ham and samphire salad", "cress | lettuce | white cabbage | parma ham | samphire" },
                    { 97, "Thin pastry cases stuffed with fish and fresh mushroom", "Fish and mushroom dumplings", "flour | water | salt | onions | fish | mushroom" },
                    { 98, "Fluffy bread made with fresh pumpkin and squash", "Pumpkin and squash bread", "flour | salt | yeast | butter | water | onions | pumpkin | squash" },
                    { 99, "Fresh plantain and pork stewed", "Plantain and pork stew", "onion | salt | black pepper | potatoes | plantain | pork" },
                    { 100, "A crunchy salad featuring wheat and French mustard", "Wheat and mustard salad", "white cabbage | tomato | cucumber | wheat | mustard" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 100);
        }
    }
}
