using API.Entities;

namespace API.Data
{
    public static class DBInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
        new Product
{
            Name= "iPhone 9",
            Description= "An apple mobile which is nothing like apple",
            Price= 54900,
            DiscountPercentage= 12.96,
            Rating= 4.69,
            QuantityInStock= 94,
            Brand= "Apple",
            Category= "smartphones",
            Thumbnail= "/images/products/products1thumbnail.jpg",
            Images=new string[]{
                "/images/products/products11.jpg",
                "/images/products/products12.jpg",
                "/images/products/products13.jpg",
                "/images/products/products14.jpg",
                "/images/products/products1thumbnail.jpg"

            }
        },
        new Product
{
            Name= "iPhone X",
            Description= "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...",
            Price= 89900,
            DiscountPercentage= 17.94,
            Rating= 4.44,
            QuantityInStock= 34,
            Brand= "Apple",
            Category= "smartphones",
            Thumbnail= "/images/products/products2thumbnail.jpg",
            Images=new string[]{
                "/images/products/products21.jpg",
                "/images/products/products22.jpg",
                "/images/products/products23.jpg",
                "/images/products/products2thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Samsung Universe 9",
            Description= "Samsung's new variant which goes beyond Galaxy to the Universe",
            Price= 124900,
            DiscountPercentage= 15.46,
            Rating= 4.09,
            QuantityInStock= 36,
            Brand= "Samsung",
            Category= "smartphones",
            Thumbnail= "/images/products/products3thumbnail.jpg",
            Images=new string[]{
                "/images/products/products31.jpg"
            }
        },
        new Product
{
            Name= "OPPO F19",
            Description= "OPPO F19 is officially announced on April 2021.",
            Price= 48000,
            DiscountPercentage= 17.91,
            Rating= 4.3,
            QuantityInStock= 123,
            Brand= "OPPO",
            Category= "smartphones",
            Thumbnail= "/images/products/products4thumbnail.jpg",
            Images=new string[]{
                "/images/products/products41.jpg",
                "/images/products/products42.jpg",
                "/images/products/products43.jpg",
                "/images/products/products44.jpg",
                "/images/products/products4thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Huawei P30",
            Description= "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.",
            Price= 49900,
            DiscountPercentage= 10.58,
            Rating= 4.09,
            QuantityInStock= 32,
            Brand= "Huawei",
            Category= "smartphones",
            Thumbnail= "/images/products/products5thumbnail.jpg",
            Images=new string[]{
                "/images/products/products51.jpg",
                "/images/products/products52.jpg",
                "/images/products/products53.jpg"
            }
        },
        new Product
{
            Name= "MacBook Pro",
            Description= "MacBook Pro 2021 with mini-LED display may launch between September, November",
            Price= 174900,
            DiscountPercentage= 11.02,
            Rating= 4.57,
            QuantityInStock= 83,
            Brand= "Apple",
            Category= "laptops",
            Thumbnail= "/images/products/products6thumbnail.png",
            Images=new string[]{
                "/images/products/products61.png",
                "/images/products/products62.jpg",
                "/images/products/products63.png",
                "/images/products/products64.jpg"
            }
        },
        new Product
{
            Name= "Samsung Galaxy Book",
            Description= "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched",
            Price= 149900,
            DiscountPercentage= 4.15,
            Rating= 4.25,
            QuantityInStock= 50,
            Brand= "Samsung",
            Category= "laptops",
            Thumbnail= "/images/products/products7thumbnail.jpg",
            Images=new string[]{
                "/images/products/products71.jpg",
                "/images/products/products72.jpg",
                "/images/products/products73.jpg",
                "/images/products/products7thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Microsoft Surface Laptop 4",
            Description= "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.",
            Price= 149900,
            DiscountPercentage= 10.23,
            Rating= 4.43,
            QuantityInStock= 68,
            Brand= "Microsoft Surface",
            Category= "laptops",
            Thumbnail= "/images/products/products8thumbnail.jpg",
            Images=new string[]{
                "/images/products/products81.jpg",
                "/images/products/products82.jpg",
                "/images/products/products83.jpg",
                "/images/products/products84.jpg",
                "/images/products/products8thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Infinix INBOOK",
            Description= "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty",
            Price= 109900,
            DiscountPercentage= 11.83,
            Rating= 4.54,
            QuantityInStock= 96,
            Brand= "Infinix",
            Category= "laptops",
            Thumbnail= "/images/products/products9thumbnail.jpg",
            Images=new string[]{
                "/images/products/products91.jpg",
                "/images/products/products92.png",
                "/images/products/products93.png",
                "/images/products/products94.jpg",
                "/images/products/products9thumbnail.jpg"
            }
        },
        new Product
{
            Name= "HP Pavilion 15-DK1056WM",
            Description= "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10",
            Price= 109900,
            DiscountPercentage= 6.18,
            Rating= 4.43,
            QuantityInStock= 89,
            Brand= "HP Pavilion",
            Category= "laptops",
            Thumbnail= "/images/products/products10thumbnail.jpeg",
            Images=new string[]{
                "/images/products/products101.jpg",
                "/images/products/products102.jpg",
                "/images/products/products103.jpg",
                "/images/products/products10thumbnail.jpeg"
            }
        },
        new Product
{
            Name= "perfume Oil",
            Description= "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil",
            Price= 1300,
            DiscountPercentage= 8.4,
            Rating= 4.26,
            QuantityInStock= 65,
            Brand= "Impression of Acqua Di Gio",
            Category= "fragrances",
            Thumbnail= "/images/products/products11thumbnail.jpg",
            Images=new string[]{
                "/images/products/products111.jpg",
                "/images/products/products112.jpg",
                "/images/products/products113.jpg",
                "/images/products/products11thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Brown Perfume",
            Description= "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml",
            Price= 4000,
            DiscountPercentage= 15.66,
            Rating= 4,
            QuantityInStock= 52,
            Brand= "Royal_Mirage",
            Category= "fragrances",
            Thumbnail= "/images/products/products12thumbnail.jpg",
            Images=new string[]{
                "/images/products/products121.jpg",
                "/images/products/products122.jpg",
                "/images/products/products123.png",
                "/images/products/products124.jpg",
                "/images/products/products12thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Fog Xpressio Perfume",
            Description= "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men",
            Price= 1300,
            DiscountPercentage= 8.14,
            Rating= 4.59,
            QuantityInStock= 61,
            Brand= "Fog Scent Xpressio",
            Category= "fragrances",
            Thumbnail= "/images/products/products13thumbnail.webp",
            Images=new string[]{
                "/images/products/products131.jpg",
                "/images/products/products132.png",
                "/images/products/products133.jpg",
                "/images/products/products134.jpg",
                "/images/products/products13thumbnail.webp"
            }
        },
        new Product
{
            Name= "Concentrated Perfume Oil",
            Description= "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil",
            Price= 12000,
            DiscountPercentage= 15.6,
            Rating= 4.21,
            QuantityInStock= 114,
            Brand= "Al Munakh",
            Category= "fragrances",
            Thumbnail= "/images/products/products14thumbnail.jpg",
            Images=new string[]{
                "/images/products/products141.jpg",
                "/images/products/products142.jpg",
                "/images/products/products143.jpg",
                "/images/products/products14thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Eau De Perfume",
            Description= "Genuine  Al-Rehab spray perfume from UAESaudi ArabiaYemen High Quality",
            Price= 3000,
            DiscountPercentage= 10.99,
            Rating= 4.7,
            QuantityInStock= 105,
            Brand= "Lord - Al-Rehab",
            Category= "fragrances",
            Thumbnail= "/images/products/products15thumbnail.jpg",
            Images=new string[]{
                "/images/products/products151.jpg",
                "/images/products/products152.jpg",
                "/images/products/products153.jpg",
                "/images/products/products154.jpg",
                "/images/products/products15thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Hyaluronic Acid Serum",
            Description= "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid",
            Price= 1900,
            DiscountPercentage= 13.31,
            Rating= 4.83,
            QuantityInStock= 110,
            Brand= "L'Oreal Paris",
            Category= "skincare",
            Thumbnail= "/images/products/products16thumbnail.jpg",
            Images=new string[]{
                "/images/products/products161.png",
                "/images/products/products162.webp",
                "/images/products/products163.jpg",
                "/images/products/products164.jpg",
                "/images/products/products16thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Tree Oil 30ml",
            Description= "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,",
            Price= 1200,
            DiscountPercentage= 4.09,
            Rating= 4.52,
            QuantityInStock= 78,
            Brand= "Hemani Tea",
            Category= "skincare",
            Thumbnail= "/images/products/products17thumbnail.jpg",
            Images=new string[]{
                "/images/products/products171.jpg",
                "/images/products/products172.jpg",
                "/images/products/products173.jpg",
                "/images/products/products17thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Oil Free Moisturizer",
            Description= "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.",
            Price= 4000,
            DiscountPercentage= 13.1,
            Rating= 4.56,
            QuantityInStock= 88,
            Brand= "Dermive",
            Category= "skincare",
            Thumbnail= "/images/products/products18thumbnail.jpg",
            Images=new string[]{
                "/images/products/products181.jpg",
                "/images/products/products182.jpg",
                "/images/products/products183.jpg",
                "/images/products/products184.jpg",
                "/images/products/products18thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Skin Beauty Serum.",
            Description= "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m",
            Price= 4600,
            DiscountPercentage= 10.68,
            Rating= 4.42,
            QuantityInStock= 54,
            Brand= "ROREC White Rice",
            Category= "skincare",
            Thumbnail= "/images/products/products19thumbnail.jpg",
            Images=new string[]{
                "/images/products/products191.jpg",
                "/images/products/products192.jpg",
                "/images/products/products193.png",
                "/images/products/products19thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Freckle Treatment Cream",
            Description= "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.",
            Price= 7000,
            DiscountPercentage= 16.99,
            Rating= 4.06,
            QuantityInStock= 140,
            Brand= "Fair & Clear",
            Category= "skincare",
            Thumbnail= "/images/products/products20thumbnail.jpg",
            Images=new string[]{
                "/images/products/products201.jpg",
                "/images/products/products202.jpg",
                "/images/products/products203.jpg",
                "/images/products/products204.jpg",
                "/images/products/products20thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Masoor Daal",
            Description= "Fine quality Branded Product Keep in a cool and dry place",
            Price= 2000,
            DiscountPercentage= 4.81,
            Rating= 4.44,
            QuantityInStock= 133,
            Brand= "Saaf & Khaas",
            Category= "groceries",
            Thumbnail= "/images/products/products21thumbnail.png",
            Images=new string[]{
                "/images/products/products211.png",
                "/images/products/products212.jpg",
                "/images/products/products213.jpg"
            }
        },
        new Product
{
            Name= "Elbow Macaroni",
            Description= "Product details of Bake Parlor Big Elbow Macaroni - 400 gm",
            Price= 1400,
            DiscountPercentage= 15.58,
            Rating= 4.57,
            QuantityInStock= 146,
            Brand= "Bake Parlor Big",
            Category= "groceries",
            Thumbnail= "/images/products/products22thumbnail.jpg",
            Images=new string[]{
                "/images/products/products221.jpg",
                "/images/products/products222.jpg",
                "/images/products/products223.jpg"
            }
        },
        new Product
{
            Name= "Essence Food Flavou",
            Description= "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item",
            Price= 1400,
            DiscountPercentage= 8.04,
            Rating= 4.85,
            QuantityInStock= 26,
            Brand= "Baking Food Items",
            Category= "groceries",
            Thumbnail= "/images/products/products23thumbnail.jpg",
            Images=new string[]{
                "/images/products/products231.jpg",
                "/images/products/products232.jpg",
                "/images/products/products233.jpg",
                "/images/products/products234.jpg",
                "/images/products/products23thumbnail.jpg"
            }
        },
        new Product
{
            Name= "muesli fruit nuts",
            Description= "original fauji cereal muesli 250gm box pack original fauji cereals muesli fruit nuts flakes breakfast cereal break fast faujicereals cerels cerel foji fouji",
            Price= 4600,
            DiscountPercentage= 16.8,
            Rating= 4.94,
            QuantityInStock= 113,
            Brand= "fauji",
            Category= "groceries",
            Thumbnail= "/images/products/products24thumbnail.jpg",
            Images=new string[]{
                "/images/products/products241.jpg",
                "/images/products/products242.jpg",
                "/images/products/products243.jpg",
                "/images/products/products244.jpg",
                "/images/products/products24thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Gulab Powder",
            Description= "Dry Rose Flower Powder Gulab Powder 50 Gram • Treats Wounds",
            Price= 7000,
            DiscountPercentage= 13.58,
            Rating= 4.87,
            QuantityInStock= 47,
            Brand= "Dry Rose",
            Category= "groceries",
            Thumbnail= "/images/products/products25thumbnail.jpg",
            Images=new string[]{
                "/images/products/products251.png",
                "/images/products/products252.jpg",
                "/images/products/products253.png",
                "/images/products/products254.jpg",
                "/images/products/products25thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Plant Hanger Home",
            Description= "Boho Decor Plant Hanger For Home Wall Decoration Macrame Wall Hanging Shelf",
            Price= 4100,
            DiscountPercentage= 17.86,
            Rating= 4.08,
            QuantityInStock= 131,
            Brand= "Boho Decor",
            Category= "home-decoration",
            Thumbnail= "/images/products/products26thumbnail.jpg",
            Images=new string[]{
                "/images/products/products261.jpg",
                "/images/products/products262.jpg",
                "/images/products/products263.jpg",
                "/images/products/products264.jpg",
                "/images/products/products265.jpg",
                "/images/products/products26thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Flying Wooden Bird",
            Description= "Package Include 6 Birds with Adhesive Tape Shape: 3D Shaped Wooden Birds Material: Wooden MDF, Laminated 3.5mm",
            Price= 5100,
            DiscountPercentage= 15.58,
            Rating= 4.41,
            QuantityInStock= 17,
            Brand= "Flying Wooden",
            Category= "home-decoration",
            Thumbnail= "/images/products/products27thumbnail.webp",
            Images=new string[]{
                "/images/products/products271.jpg",
                "/images/products/products272.jpg",
                "/images/products/products273.jpg",
                "/images/products/products274.jpg",
                "/images/products/products27thumbnail.webp"
            }
        },
        new Product
{
            Name= "Embellishment Art Lamp",
            Description= "3D led lamp sticker Wall sticker 3d wall art light onoff button  cell operated (included)",
            Price= 2000,
            DiscountPercentage= 16.49,
            Rating= 4.82,
            QuantityInStock= 54,
            Brand= "LED Lights",
            Category= "home-decoration",
            Thumbnail= "/images/products/products28thumbnail.jpg",
            Images=new string[]{
                "/images/products/products281.jpg",
                "/images/products/products282.jpg",
                "/images/products/products283.png",
                "/images/products/products284.jpg",
                "/images/products/products28thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Handcraft Chinese style",
            Description= "Handcraft Chinese style art luxury palace hotel villa mansion home decor ceramic vase with brass fruit plate",
            Price= 6000,
            DiscountPercentage= 15.34,
            Rating= 4.44,
            QuantityInStock= 7,
            Brand= "luxury palace",
            Category= "home-decoration",
            Thumbnail= "/images/products/products29thumbnail.webp",
            Images=new string[]{
                "/images/products/products291.jpg",
                "/images/products/products292.jpg",
                "/images/products/products293.webp",
                "/images/products/products294.webp",
                "/images/products/products29thumbnail.webp"
            }
        },
        new Product
{
            Name= "Key Holder",
            Description= "Attractive DesignMetallic materialFour key hooksReliable & DurablePremium Quality",
            Price= 3000,
            DiscountPercentage= 2.92,
            Rating= 4.92,
            QuantityInStock= 54,
            Brand= "Golden",
            Category= "home-decoration",
            Thumbnail= "/images/products/products30thumbnail.jpg",
            Images=new string[]{
                "/images/products/products301.jpg",
                "/images/products/products302.jpg",
                "/images/products/products303.jpg",
                "/images/products/products30thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Mornadi Velvet Bed",
            Description= "Mornadi Velvet Bed Base with Headboard Slats Support Classic Style Bedroom Furniture Bed Set",
            Price= 4000,
            DiscountPercentage= 17,
            Rating= 4.16,
            QuantityInStock= 140,
            Brand= "Furniture Bed Set",
            Category= "furniture",
            Thumbnail= "/images/products/products31thumbnail.jpg",
            Images=new string[]{
                "/images/products/products311.jpg",
                "/images/products/products312.jpg",
                "/images/products/products313.jpg",
                "/images/products/products314.jpg",
                "/images/products/products31thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Coffe Cafe Sofa",
            Description= "Ratttan Outdoor furniture Set Waterproof  Rattan Sofa for Coffe Cafe",
            Price= 5000,
            DiscountPercentage= 15.59,
            Rating= 4.74,
            QuantityInStock= 30,
            Brand= "Ratttan Outdoor",
            Category= "furniture",
            Thumbnail= "/images/products/products32thumbnail.jpg",
            Images=new string[]{
                "/images/products/products321.jpg",
                "/images/products/products322.jpg",
                "/images/products/products323.jpg",
                "/images/products/products32thumbnail.jpg"
            }
        },
        new Product
{
            Name= "3 Tier Shelves",
            Description= "3 Tier Corner Shelves | 3 PCs Wall Mount Kitchen Shelf | Floating Bedroom Shelf",
            Price= 70000,
            DiscountPercentage= 17,
            Rating= 4.31,
            QuantityInStock= 106,
            Brand= "Kitchen Shelf",
            Category= "furniture",
            Thumbnail= "/images/products/products33thumbnail.jpg",
            Images=new string[]{
                "/images/products/products331.jpg",
                "/images/products/products332.jpg",
                "/images/products/products333.jpg",
                "/images/products/products334.jpg",
                "/images/products/products33thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Plastic Table",
            Description= "Very good quality plastic table for multi purpose now in reasonable price",
            Price= 5000,
            DiscountPercentage= 4,
            Rating= 4.01,
            QuantityInStock= 136,
            Brand= "Multi Purpose",
            Category= "furniture",
            Thumbnail= "/images/products/products34thumbnail.jpg",
            Images=new string[]{
                "/images/products/products341.jpg",
                "/images/products/products342.jpg",
                "/images/products/products343.jpg",
                "/images/products/products344.jpg",
                "/images/products/products34thumbnail.jpg"
            }
        },
        new Product
{
            Name= "3 DOOR PORTABLE",
            Description= "Material: Stainless Steel and Fabric  Item Size: 110 cm x 45 cm x 175 cm Package Contents: 1 Storage Wardrobe",
            Price= 4100,
            DiscountPercentage= 7.98,
            Rating= 4.06,
            QuantityInStock= 68,
            Brand= "AmnaMart",
            Category= "furniture",
            Thumbnail= "/images/products/products35thumbnail.jpg",
            Images=new string[]{
                "/images/products/products351.jpg",
                "/images/products/products352.jpg",
                "/images/products/products353.jpg",
                "/images/products/products354.jpg",
                "/images/products/products35thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Sleeve Shirt Womens",
            Description= "Cotton Solid Color Professional Wear Sleeve Shirt Womens Work Blouses Wholesale Clothing Casual Plain Custom Top OEM Customized",
            Price= 9000,
            DiscountPercentage= 10.89,
            Rating= 4.26,
            QuantityInStock= 39,
            Brand= "Professional Wear",
            Category= "tops",
            Thumbnail= "/images/products/products36thumbnail.jpg",
            Images=new string[]{
                "/images/products/products361.jpg",
                "/images/products/products362.webp",
                "/images/products/products363.webp",
                "/images/products/products364.jpg",
                "/images/products/products36thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Tops for WomensGirls",
            Description= "PACK OF 3 CAMISOLES ,VERY COMFORTABLE SOFT COTTON STUFF, COMFORTABLE IN ALL FOUR SEASONS",
            Price= 5000,
            DiscountPercentage= 12.05,
            Rating= 4.52,
            QuantityInStock= 107,
            Brand= "Soft Cotton",
            Category= "tops",
            Thumbnail= "/images/products/products37thumbnail.jpg",
            Images=new string[]{
                "/images/products/products371.jpg",
                "/images/products/products372.jpg",
                "/images/products/products373.jpg",
                "/images/products/products374.jpg",
                "/images/products/products37thumbnail.jpg"
            }
        },
        new Product
{
            Name= "sublimation kids tank",
            Description= "sublimation plain kids tank tops wholesale",
            Price= 10000,
            DiscountPercentage= 11.12,
            Rating= 4.8,
            QuantityInStock= 20,
            Brand= "Soft Cotton",
            Category= "tops",
            Thumbnail= "/images/products/products38thumbnail.jpg",
            Images=new string[]{
                "/images/products/products381.png",
                "/images/products/products382.jpg",
                "/images/products/products383.jpg",
                "/images/products/products384.jpg"
            }
        },
        new Product
{
            Name= "Women Sweaters Wool",
            Description= "2021 Custom Winter Fall Zebra Knit Crop Top Women Sweaters Wool Mohair Cos Customize Crew Neck Women' S Crop Top Sweater",
            Price= 60000,
            DiscountPercentage= 17.2,
            Rating= 4.55,
            QuantityInStock= 55,
            Brand= "Top Sweater",
            Category= "tops",
            Thumbnail= "/images/products/products39thumbnail.jpg",
            Images=new string[]{
                "/images/products/products391.jpg",
                "/images/products/products392.jpg",
                "/images/products/products393.jpg",
                "/images/products/products394.jpg",
                "/images/products/products39thumbnail.jpg"
            }
        },
        new Product
{
            Name= "women winter clothes",
            Description= "women winter clothes thick fleece hoodie top with sweat pantjogger women sweatsuit set joggers pants two piece pants set",
            Price= 5700,
            DiscountPercentage= 13.39,
            Rating= 4.91,
            QuantityInStock= 84,
            Brand= "Top Sweater",
            Category= "tops",
            Thumbnail= "/images/products/products40thumbnail.jpg",
            Images=new string[]{
                "/images/products/products401.jpg",
                "/images/products/products402.jpg"
            }
        },
        new Product
{
            Name= "NIGHT SUIT",
            Description= "NIGHT SUIT RED MICKY MOUSE..  For Girls. Fantastic Suits.",
            Price= 5500,
            DiscountPercentage= 15.05,
            Rating= 4.65,
            QuantityInStock= 21,
            Brand= "RED MICKY MOUSE..",
            Category= "womens-dresses",
            Thumbnail= "/images/products/products41thumbnail.webp",
            Images=new string[]{
                "/images/products/products411.jpg",
                "/images/products/products412.webp",
                "/images/products/products413.jpg",
                "/images/products/products414.jpg",
                "/images/products/products41thumbnail.webp"
            }
        },
        new Product
{
            Name= "Kurta plus trouser",
            Description= "FABRIC: LILEIN CHEST: 21 LENGHT: 37 TROUSER: (38) :ARABIC LILEIN",
            Price= 8000,
            DiscountPercentage= 15.37,
            Rating= 4.05,
            QuantityInStock= 148,
            Brand= "Digital Printed",
            Category= "womens-dresses",
            Thumbnail= "/images/products/products42thumbnail.jpg",
            Images=new string[]{
                "/images/products/products421.png",
                "/images/products/products422.png",
                "/images/products/products423.png",
                "/images/products/products424.jpg",
                "/images/products/products42thumbnail.jpg"
            }
        },
        new Product
{
            Name= "frock gold printed",
            Description= "Ghazi fabric long frock gold printed ready to wear stitched collection (G992)",
            Price= 60000,
            DiscountPercentage= 15.55,
            Rating= 4.31,
            QuantityInStock= 150,
            Brand= "Ghazi Fabric",
            Category= "womens-dresses",
            Thumbnail= "/images/products/products43thumbnail.jpg",
            Images=new string[]{
                "/images/products/products431.jpg",
                "/images/products/products432.jpg",
                "/images/products/products433.jpg",
                "/images/products/products434.jpg",
                "/images/products/products43thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Ladies Multicolored Dress",
            Description= "This classy shirt for women gives you a gorgeous look on everyday wear and specially for semi-casual wears.",
            Price= 7900,
            DiscountPercentage= 16.88,
            Rating= 4.03,
            QuantityInStock= 2,
            Brand= "Ghazi Fabric",
            Category= "womens-dresses",
            Thumbnail= "/images/products/products44thumbnail.jpg",
            Images=new string[]{
                "/images/products/products441.jpg",
                "/images/products/products442.jpg",
                "/images/products/products443.jpg",
                "/images/products/products444.jpg",
                "/images/products/products44thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Malai Maxi Dress",
            Description= "Ready to wear, Unique design according to modern standard fashion, Best fitting ,Imported stuff",
            Price= 5000,
            DiscountPercentage= 5.07,
            Rating= 4.67,
            QuantityInStock= 96,
            Brand= "IELGY",
            Category= "womens-dresses",
            Thumbnail= "/images/products/products45thumbnail.jpg",
            Images=new string[]{
                "/images/products/products451.jpg",
                "/images/products/products452.webp",
                "/images/products/products453.jpg",
                "/images/products/products454.jpg",
                "/images/products/products45thumbnail.jpg"
            }
        },
        new Product
{
            Name= "women's shoes",
            Description= "Close: Lace, Style with bottom: Increased inside, Sole Material: Rubber",
            Price= 4000,
            DiscountPercentage= 16.96,
            Rating= 4.14,
            QuantityInStock= 72,
            Brand= "IELGY fashion",
            Category= "womens-shoes",
            Thumbnail= "/images/products/products46thumbnail.jpg",
            Images=new string[]{
                "/images/products/products461.webp",
                "/images/products/products462.jpg",
                "/images/products/products463.jpg",
                "/images/products/products464.jpg",
                "/images/products/products46thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Sneaker shoes",
            Description= "Synthetic Leather Casual Sneaker shoes for Womengirls Sneakers For Women",
            Price= 12000,
            DiscountPercentage= 10.37,
            Rating= 4.19,
            QuantityInStock= 50,
            Brand= "Synthetic Leather",
            Category= "womens-shoes",
            Thumbnail= "/images/products/products47thumbnail.jpeg",
            Images=new string[]{
                "/images/products/products471.jpg",
                "/images/products/products472.jpg",
                "/images/products/products473.jpg",
                "/images/products/products47thumbnail.jpeg"
            }
        },
        new Product
{
            Name= "Women Strip Heel",
            Description= "Features: Flip-flops, Mid Heel, Comfortable, Striped Heel, Antiskid, Striped",
            Price= 4000,
            DiscountPercentage= 10.83,
            Rating= 4.02,
            QuantityInStock= 25,
            Brand= "Sandals Flip Flops",
            Category= "womens-shoes",
            Thumbnail= "/images/products/products48thumbnail.jpg",
            Images=new string[]{
                "/images/products/products481.jpg",
                "/images/products/products482.jpg",
                "/images/products/products483.jpg",
                "/images/products/products484.jpg",
                "/images/products/products48thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Chappals/Shoe Ladies",
            Description= "Womens Chappals & Shoe Ladies Metallic Tong Thong Sandal Flat Summer 2020 Maasai Sandals",
            Price= 2300,
            DiscountPercentage= 2.62,
            Rating= 4.72,
            QuantityInStock= 107,
            Brand= "Maasai Sandals",
            Category= "womens-shoes",
            Thumbnail= "/images/products/products49thumbnail.jpg",
            Images=new string[]{
                "/images/products/products491.jpg",
                "/images/products/products492.jpg",
                "/images/products/products493.webp",
                "/images/products/products49thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Women Shoes",
            Description= "2020 New Arrivals Genuine Leather Fashion Trend Platform Summer Women Shoes",
            Price= 3600,
            DiscountPercentage= 16.87,
            Rating= 4.33,
            QuantityInStock= 46,
            Brand= "Arrivals Genuine",
            Category= "womens-shoes",
            Thumbnail= "/images/products/products50thumbnail.jpg",
            Images=new string[]{
                "/images/products/products501.jpeg",
                "/images/products/products502.jpg",
                "/images/products/products503.jpg"
            }
        },
        new Product
{
            Name= "half sleeves Tshirts",
            Description= "Many store is creating new designs and trend every month and every year. Daraz.pk have a beautiful range of men fashion brands",
            Price= 2300,
            DiscountPercentage= 12.76,
            Rating= 4.26,
            QuantityInStock= 132,
            Brand= "Vintage Apparel",
            Category= "mens-shirts",
            Thumbnail= "/images/products/products51thumbnail.jpg",
            Images=new string[]{
                "/images/products/products511.png",
                "/images/products/products512.jpg",
                "/images/products/products513.jpg",
                "/images/products/products51thumbnail.jpg"
            }
        },
        new Product
{
            Name= "FREE FIRE TShirt",
            Description= "quality and professional print - It doesn't just look high quality, it is high quality.",
            Price= 1000,
            DiscountPercentage= 14.72,
            Rating= 4.52,
            QuantityInStock= 128,
            Brand= "FREE FIRE",
            Category= "mens-shirts",
            Thumbnail= "/images/products/products52thumbnail.jpg",
            Images=new string[]{
                "/images/products/products521.png",
                "/images/products/products522.png",
                "/images/products/products523.jpg",
                "/images/products/products524.jpg",
                "/images/products/products52thumbnail.jpg"
            }
        },
        new Product
{
            Name= "high quality Tshirts",
            Description= "Brand: vintage Apparel ,Export quality",
            Price= 3500,
            DiscountPercentage= 7.54,
            Rating= 4.89,
            QuantityInStock= 6,
            Brand= "Vintage Apparel",
            Category= "mens-shirts",
            Thumbnail= "/images/products/products53thumbnail.jpg",
            Images=new string[]{
                "/images/products/products531.webp",
                "/images/products/products532.jpg",
                "/images/products/products533.jpg",
                "/images/products/products534.jpg",
                "/images/products/products53thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Pubg Graphic TShirt",
            Description= "Product Description Features: 100% Ultra soft Polyester Jersey. Vibrant & colorful printing on front. Feels soft as cotton without ever cracking",
            Price= 4600,
            DiscountPercentage= 16.44,
            Rating= 4.62,
            QuantityInStock= 136,
            Brand= "The Warehouse",
            Category= "mens-shirts",
            Thumbnail= "/images/products/products54thumbnail.jpg",
            Images=new string[]{
                "/images/products/products541.jpg",
                "/images/products/products542.jpg",
                "/images/products/products543.jpg",
                "/images/products/products544.jpg",
                "/images/products/products54thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Money Heist T Shirts",
            Description= "Fabric Jercy, Size: M & L Wear Stylish Dual Stiched",
            Price= 6600,
            DiscountPercentage= 15.97,
            Rating= 4.9,
            QuantityInStock= 122,
            Brand= "The Warehouse",
            Category= "mens-shirts",
            Thumbnail= "/images/products/products55thumbnail.jpg",
            Images=new string[]{
                "/images/products/products551.jpg",
                "/images/products/products552.webp",
                "/images/products/products553.jpg",
                "/images/products/products554.jpg",
                "/images/products/products55thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Sneakers Joggers Shoes",
            Description= "Gender: Men , Colors: Same as DisplayedCondition: 100% Brand New",
            Price= 4000,
            DiscountPercentage= 12.57,
            Rating= 4.38,
            QuantityInStock= 6,
            Brand= "Sneakers",
            Category= "mens-shoes",
            Thumbnail= "/images/products/products56thumbnail.jpg",
            Images=new string[]{
                "/images/products/products561.jpg",
                "/images/products/products562.jpg",
                "/images/products/products563.jpg",
                "/images/products/products564.jpg",
                "/images/products/products565.jpg",
                "/images/products/products56thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Loafers for men",
            Description= "Men Shoes - Loafers for men - Rubber Shoes - Nylon Shoes - Shoes for men - Moccassion - Pure Nylon (Rubber) Expot Quality.",
            Price= 4700,
            DiscountPercentage= 10.91,
            Rating= 4.91,
            QuantityInStock= 20,
            Brand= "Rubber",
            Category= "mens-shoes",
            Thumbnail= "/images/products/products57thumbnail.jpg",
            Images=new string[]{
                "/images/products/products571.jpg",
                "/images/products/products572.jpg",
                "/images/products/products573.jpg",
                "/images/products/products574.jpg",
                "/images/products/products57thumbnail.jpg"
            }
        },
        new Product
{
            Name= "formal offices shoes",
            Description= "Pattern Type: Solid, Material: PU, Toe Shape: Pointed Toe ,Outsole Material: Rubber",
            Price= 5700,
            DiscountPercentage= 12,
            Rating= 4.41,
            QuantityInStock= 68,
            Brand= "The Warehouse",
            Category= "mens-shoes",
            Thumbnail= "/images/products/products58thumbnail.jpg",
            Images=new string[]{
                "/images/products/products581.jpg",
                "/images/products/products582.jpg",
                "/images/products/products583.jpg",
                "/images/products/products584.jpg",
                "/images/products/products58thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Spring and summershoes",
            Description= "Comfortable stretch cloth, lightweight body; ,rubber sole, anti-skid wear;",
            Price= 2000,
            DiscountPercentage= 8.71,
            Rating= 4.33,
            QuantityInStock= 137,
            Brand= "Sneakers",
            Category= "mens-shoes",
            Thumbnail= "/images/products/products59thumbnail.jpg",
            Images=new string[]{
                "/images/products/products591.jpg",
                "/images/products/products592.jpg",
                "/images/products/products593.jpg",
                "/images/products/products594.jpg",
                "/images/products/products59thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Casual Jeans Shoes",
            Description= "High Quality ,Stylish design ,Comfortable wear ,FAshion ,Durable",
            Price= 5800,
            DiscountPercentage= 7.55,
            Rating= 4.55,
            QuantityInStock= 129,
            Brand= "Sneakers",
            Category= "mens-shoes",
            Thumbnail= "/images/products/products60thumbnail.jpg",
            Images=new string[]{
                "/images/products/products601.jpg",
                "/images/products/products602.jpg",
                "/images/products/products603.jpg",
                "/images/products/products60thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Leather Straps Wristwatch",
            Description= "Style:Sport ,Clasp:Buckles ,Water Resistance Depth:3Bar",
            Price= 12000,
            DiscountPercentage= 7.14,
            Rating= 4.63,
            QuantityInStock= 91,
            Brand= "Naviforce",
            Category= "mens-watches",
            Thumbnail= "/images/products/products61thumbnail.jpg",
            Images=new string[]{
                "/images/products/products611.jpg",
                "/images/products/products612.png",
                "/images/products/products613.jpg"
            }
        },
        new Product
{
            Name= "Leather Brand Watch",
            Description= "Watch Crown With Environmental IPS Bronze Electroplating; Display system of 12 hours",
            Price= 4600,
            DiscountPercentage= 3.15,
            Rating= 4.05,
            QuantityInStock= 95,
            Brand= "SKMEI 9117",
            Category= "mens-watches",
            Thumbnail= "/images/products/products62thumbnail.jpg",
            Images=new string[]{
                "/images/products/products621.jpg",
                "/images/products/products622.jpg"
            }
        },
        new Product
{
            Name= "Blue Premium Watch",
            Description= "Men Silver Chain Royal Blue Premium Watch Latest Analog Watch",
            Price= 5000,
            DiscountPercentage= 2.56,
            Rating= 4.89,
            QuantityInStock= 142,
            Brand= "SKMEI 9117",
            Category= "mens-watches",
            Thumbnail= "/images/products/products63thumbnail.webp",
            Images=new string[]{
                "/images/products/products631.jpg",
                "/images/products/products632.jpg",
                "/images/products/products633.png",
                "/images/products/products634.jpeg"
            }
        },
        new Product
{
            Name= "Leather Strap Skeleton Watch",
            Description= "Leather Strap Skeleton Watch for Men - Stylish and Latest Design",
            Price= 4600,
            DiscountPercentage= 10.2,
            Rating= 4.98,
            QuantityInStock= 61,
            Brand= "Strap Skeleton",
            Category= "mens-watches",
            Thumbnail= "/images/products/products64thumbnail.jpg",
            Images=new string[]{
                "/images/products/products641.jpg",
                "/images/products/products642.webp",
                "/images/products/products643.jpg",
                "/images/products/products64thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Stainless Steel Watch",
            Description= "Stylish Watch For Man (Luxury) Classy Men's Stainless Steel Wrist Watch - Box Packed",
            Price= 4700,
            DiscountPercentage= 17.79,
            Rating= 4.79,
            QuantityInStock= 94,
            Brand= "Stainless",
            Category= "mens-watches",
            Thumbnail= "/images/products/products65thumbnail.webp",
            Images=new string[]{
                "/images/products/products651.jpg",
                "/images/products/products652.webp",
                "/images/products/products653.jpg",
                "/images/products/products654.webp",
                "/images/products/products65thumbnail.webp"
            }
        },
        new Product
{
            Name= "Analog Couple Watches",
            Description= "Elegant design, Stylish ,Unique & Trendy,Comfortable wear",
            Price= 3500,
            DiscountPercentage= 3.23,
            Rating= 4.79,
            QuantityInStock= 24,
            Brand= "Eastern Watches",
            Category= "womens-watches",
            Thumbnail= "/images/products/products66thumbnail.jpg",
            Images=new string[]{
                "/images/products/products661.jpg",
                "/images/products/products662.jpg",
                "/images/products/products663.jpg",
                "/images/products/products664.JPG",
                "/images/products/products66thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Fashion Magnetic Watch",
            Description= "Buy this awesome  The product is originally manufactured by the company and it's a top selling product with a very reasonable",
            Price= 6000,
            DiscountPercentage= 16.69,
            Rating= 4.03,
            QuantityInStock= 46,
            Brand= "Eastern Watches",
            Category= "womens-watches",
            Thumbnail= "/images/products/products67thumbnail.jpg",
            Images=new string[]{
                "/images/products/products671.jpg",
                "/images/products/products672.jpg",
                "/images/products/products673.jpg",
                "/images/products/products674.jpg",
                "/images/products/products67thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Luxury Digital Watch",
            Description= "Stylish Luxury Digital Watch For Girls  Women - Led Smart Ladies Watches For Girls",
            Price= 5700,
            DiscountPercentage= 9.03,
            Rating= 4.55,
            QuantityInStock= 77,
            Brand= "Luxury Digital",
            Category= "womens-watches",
            Thumbnail= "/images/products/products68thumbnail.webp",
            Images=new string[]{
                "/images/products/products681.jpg",
                "/images/products/products682.jpg"
            }
        },
        new Product
{
            Name= "Golden Pearls Watch",
            Description= "Product details of Golden Watch Pearls Bracelet Watch For Girls - Golden Chain Ladies Bracelate Watch for Women",
            Price= 4700,
            DiscountPercentage= 17.55,
            Rating= 4.77,
            QuantityInStock= 89,
            Brand= "Watch Pearls",
            Category= "womens-watches",
            Thumbnail= "/images/products/products69thumbnail.jpg",
            Images=new string[]{
                "/images/products/products691.jpg",
                "/images/products/products692.jpg",
                "/images/products/products693.webp",
                "/images/products/products694.jpg",
                "/images/products/products69thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Stainless Steel Women",
            Description= "Fashion Skmei 1830 Shell Dial Stainless Steel Women Wrist Watch Lady Bracelet Watch Quartz Watches Ladies",
            Price= 3500,
            DiscountPercentage= 8.98,
            Rating= 4.08,
            QuantityInStock= 111,
            Brand= "Bracelet",
            Category= "womens-watches",
            Thumbnail= "/images/products/products70thumbnail.jpg",
            Images=new string[]{
                "/images/products/products701.jpg",
                "/images/products/products702.jpg",
                "/images/products/products70thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Women Shoulder Bags",
            Description= "LouisWill Women Shoulder Bags Long Clutches Cross Body Bags Phone Bags PU Leather Hand Bags Large Capacity Card Holders Zipper Coin Purses Fashion Crossbody Bags for Girls Ladies",
            Price= 4600,
            DiscountPercentage= 14.65,
            Rating= 4.71,
            QuantityInStock= 17,
            Brand= "LouisWill",
            Category= "womens-bags",
            Thumbnail= "/images/products/products71thumbnail.jpg",
            Images=new string[]{
                "/images/products/products711.jpg",
                "/images/products/products712.jpg",
                "/images/products/products713.webp",
                "/images/products/products71thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Handbag For Girls",
            Description= "This fashion is designed to add a charming effect to your casual outfit. This Bag is made of synthetic leather.",
            Price= 2300,
            DiscountPercentage= 17.5,
            Rating= 4.91,
            QuantityInStock= 27,
            Brand= "LouisWill",
            Category= "womens-bags",
            Thumbnail= "/images/products/products72thumbnail.webp",
            Images=new string[]{
                "/images/products/products721.jpg",
                "/images/products/products722.png",
                "/images/products/products723.webp",
                "/images/products/products724.jpg",
                "/images/products/products72thumbnail.webp"
            }
        },
        new Product
{
            Name= "Fancy hand clutch",
            Description= "This fashion is designed to add a charming effect to your casual outfit. This Bag is made of synthetic leather.",
            Price= 4400,
            DiscountPercentage= 10.39,
            Rating= 4.18,
            QuantityInStock= 101,
            Brand= "Bracelet",
            Category= "womens-bags",
            Thumbnail= "/images/products/products73thumbnail.jpg",
            Images=new string[]{
                "/images/products/products731.jpg",
                "/images/products/products732.webp",
                "/images/products/products733.jpg",
                "/images/products/products73thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Leather Hand Bag",
            Description= "It features an attractive design that makes it a must have accessory in your collection. We sell different kind of bags for boys, kids, women, girls and also for unisex.",
            Price= 5700,
            DiscountPercentage= 11.19,
            Rating= 4.01,
            QuantityInStock= 43,
            Brand= "Copenhagen Luxe",
            Category= "womens-bags",
            Thumbnail= "/images/products/products74thumbnail.jpg",
            Images=new string[]{
                "/images/products/products741.jpg",
                "/images/products/products742.jpg",
                "/images/products/products743.jpg",
                "/images/products/products744.jpg",
                "/images/products/products74thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Seven Pocket Women Bag",
            Description= "Seven Pocket Women Bag Handbags Lady Shoulder Crossbody Bag Female Purse Seven Pocket Bag",
            Price= 6800,
            DiscountPercentage= 14.87,
            Rating= 4.93,
            QuantityInStock= 13,
            Brand= "Steal Frame",
            Category= "womens-bags",
            Thumbnail= "/images/products/products75thumbnail.jpg",
            Images=new string[]{
                "/images/products/products751.jpg",
                "/images/products/products752.jpg",
                "/images/products/products753.jpg",
                "/images/products/products75thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Silver Ring Set Women",
            Description= "Jewelry Type:RingsCertificate Type:NonePlating:Silver PlatedShapeattern:noneStyle:CLASSICReligious",
            Price= 7000,
            DiscountPercentage= 13.57,
            Rating= 4.61,
            QuantityInStock= 51,
            Brand= "Darojay",
            Category= "womens-jewellery",
            Thumbnail= "/images/products/products76thumbnail.jpg",
            Images=new string[]{
                "/images/products/products761.jpg",
                "/images/products/products762.jpg",
                "/images/products/products76thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Rose Ring",
            Description= "Brand: The Greetings Flower Colour: RedRing Colour: GoldenSize: Adjustable",
            Price= 10000,
            DiscountPercentage= 3.22,
            Rating= 4.21,
            QuantityInStock= 149,
            Brand= "Copenhagen Luxe",
            Category= "womens-jewellery",
            Thumbnail= "/images/products/products77thumbnail.jpg",
            Images=new string[]{
                "/images/products/products771.jpg",
                "/images/products/products772.jpg",
                "/images/products/products773.jpg",
                "/images/products/products77thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Korean Style Rings",
            Description= "Fashion Jewellery 3Pcs Adjustable Pearl Rhinestone Korean Style Open Rings For Women",
            Price= 3000,
            DiscountPercentage= 8.02,
            Rating= 4.69,
            QuantityInStock= 9,
            Brand= "Fashion Jewellery",
            Category= "womens-jewellery",
            Thumbnail= "/images/products/products78thumbnail.jpg",
            Images=new string[]{
                "/images/products/products78thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Female Pearl Earrings",
            Description= "Elegant Female Pearl Earrings Set Zircon Pearl Earings Women Party Accessories 9 PairsSet",
            Price= 3000,
            DiscountPercentage= 12.8,
            Rating= 4.74,
            QuantityInStock= 16,
            Brand= "Fashion Jewellery",
            Category= "womens-jewellery",
            Thumbnail= "/images/products/products79thumbnail.jpg",
            Images=new string[]{
                "/images/products/products791.jpg"
            }
        },
        new Product
{
            Name= "Chain Pin Earrings",
            Description= "Pair Of Ear Cuff Butterfly Long Chain Pin Tassel Earrings - Silver ( Long Life Quality Product)",
            Price= 4500,
            DiscountPercentage= 17.75,
            Rating= 4.59,
            QuantityInStock= 9,
            Brand= "Cuff Butterfly",
            Category= "womens-jewellery",
            Thumbnail= "/images/products/products80thumbnail.jpg",
            Images=new string[]{
                "/images/products/products801.jpg",
                "/images/products/products802.jpg",
                "/images/products/products803.png",
                "/images/products/products804.jpg",
                "/images/products/products80thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Round Silver Sun Glasses",
            Description= "A pair of sunglasses can protect your eyes from being hurt. For car driving, vacation travel, outdoor activities, social gatherings,",
            Price= 1900,
            DiscountPercentage= 10.1,
            Rating= 4.94,
            QuantityInStock= 78,
            Brand= "Designer Sun Glasses",
            Category= "sunglasses",
            Thumbnail= "/images/products/products81thumbnail.jpg",
            Images=new string[]{
                "/images/products/products811.jpg",
                "/images/products/products812.jpg",
                "/images/products/products813.jpg",
                "/images/products/products814.webp",
                "/images/products/products81thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Square Sunglass",
            Description= "Orignal Metal Kabir Singh design 2020 Sunglasses Men Brand Designer Sun Glasses Kabir Singh Square Sunglass",
            Price= 5000,
            DiscountPercentage= 15.6,
            Rating= 4.62,
            QuantityInStock= 78,
            Brand= "Designer Sun Glasses",
            Category= "sunglasses",
            Thumbnail= "/images/products/products82thumbnail.jpg",
            Images=new string[]{
                "/images/products/products821.jpg",
                "/images/products/products822.webp",
                "/images/products/products823.jpg",
                "/images/products/products824.jpg",
                "/images/products/products82thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Night Vision Glasses",
            Description= "Wiley X Night Vision Yellow Glasses for Riders - Night Vision Anti Fog Driving Glasses - Free Night Glass Cover - Shield Eyes From Dust and Virus- For Night Sport Matches",
            Price= 3000,
            DiscountPercentage= 6.33,
            Rating= 4.97,
            QuantityInStock= 115,
            Brand= "mastar watch",
            Category= "sunglasses",
            Thumbnail= "/images/products/products83thumbnail.jpg",
            Images=new string[]{
                "/images/products/products831.jpg",
                "/images/products/products832.jpg",
                "/images/products/products833.jpg",
                "/images/products/products834.jpg",
                "/images/products/products83thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Square Sunglasses",
            Description= "Fashion Oversized Square Sunglasses Retro Gradient Big Frame Sunglasses For Women One Piece Gafas Shade Mirror Clear Lens 17059",
            Price= 2800,
            DiscountPercentage= 13.89,
            Rating= 4.64,
            QuantityInStock= 64,
            Brand= "mastar watch",
            Category= "sunglasses",
            Thumbnail= "/images/products/products84thumbnail.jpg",
            Images=new string[]{
                "/images/products/products841.jpg",
                "/images/products/products842.jpg",
                "/images/products/products84thumbnail.jpg"
            }
        },
        new Product
{
            Name= "LouisWill Men Sunglasses",
            Description= "LouisWill Men Sunglasses Polarized Sunglasses UV400 Sunglasses Day Night Dual Use Safety Driving Night Vision Eyewear AL-MG Frame Sun Glasses with Free Box for Drivers",
            Price= 5000,
            DiscountPercentage= 11.27,
            Rating= 4.98,
            QuantityInStock= 92,
            Brand= "LouisWill",
            Category= "sunglasses",
            Thumbnail= "/images/products/products85thumbnail.jpg",
            Images=new string[]{
                "/images/products/products851.jpg",
                "/images/products/products852.jpg",
                "/images/products/products85thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Bluetooth Aux",
            Description= "Bluetooth Aux Bluetooth Car Aux Car Bluetooth Transmitter Aux Audio Receiver Handfree Car Bluetooth Music Receiver Universal 3.5mm Streaming A2DP Wireless Auto AUX Audio Adapter With Mic For Phone MP3",
            Price= 2500,
            DiscountPercentage= 10.56,
            Rating= 4.57,
            QuantityInStock= 22,
            Brand= "Car Aux",
            Category= "automotive",
            Thumbnail= "/images/products/products86thumbnail.jpg",
            Images=new string[]{
                "/images/products/products861.jpg",
                "/images/products/products862.webp",
                "/images/products/products863.jpg",
                "/images/products/products864.jpg",
                "/images/products/products86thumbnail.jpg"
            }
        },
        new Product
{
            Name= "t Temperature Controller Incubator",
            Description= "Both Heat and Cool Purpose, Temperature control range; -50 to +110, Temperature measurement accuracy; 0.1, Control accuracy; 0.1",
            Price= 4000,
            DiscountPercentage= 11.3,
            Rating= 4.54,
            QuantityInStock= 37,
            Brand= "W1209 DC12V",
            Category= "automotive",
            Thumbnail= "/images/products/products87thumbnail.jpg",
            Images=new string[]{
                "/images/products/products871.jpg",
                "/images/products/products872.jpg",
                "/images/products/products873.jpg",
                "/images/products/products874.jpg",
                "/images/products/products87thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Reusable Washing Gloves",
            Description= "TC Reusable Silicone Magic Washing Gloves with Scrubber, Cleaning Brush Scrubber Gloves Heat Resistant Pair for Cleaning of Kitchen, Dishes, Vegetables and Fruits, Bathroom, Car Wash, Pet Care and Multipurpose",
            Price= 2900,
            DiscountPercentage= 3.19,
            Rating= 4.98,
            QuantityInStock= 42,
            Brand= "TC Reusable",
            Category= "automotive",
            Thumbnail= "/images/products/products88thumbnail.jpg",
            Images=new string[]{
                "/images/products/products881.jpg",
                "/images/products/products882.jpg",
                "/images/products/products883.jpg",
                "/images/products/products884.webp",
                "/images/products/products88thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Qualcomm Car Charger",
            Description= "best Quality CHarger , Highly Recommended to all best Quality CHarger , Highly Recommended to all",
            Price= 4000,
            DiscountPercentage= 17.53,
            Rating= 4.2,
            QuantityInStock= 79,
            Brand= "TC Reusable",
            Category= "automotive",
            Thumbnail= "/images/products/products89thumbnail.jpg",
            Images=new string[]{
                "/images/products/products891.jpg",
                "/images/products/products892.jpg",
                "/images/products/products893.jpg",
                "/images/products/products894.jpg",
                "/images/products/products89thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Cycle Bike Glow",
            Description= "Universal fitment and easy to install no special wires, can be easily installed and removed. Fits most standard tyre air stem valves of road, mountain bicycles, motocycles and cars.Bright led will turn on w",
            Price= 3500,
            DiscountPercentage= 11.08,
            Rating= 4.1,
            QuantityInStock= 63,
            Brand= "Neon LED Light",
            Category= "automotive",
            Thumbnail= "/images/products/products90thumbnail.jpg",
            Images=new string[]{
                "/images/products/products901.jpg",
                "/images/products/products902.jpg",
                "/images/products/products903.jpg",
                "/images/products/products904.jpg",
                "/images/products/products90thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Black Motorbike",
            Description= "Engine Type:Wet sump, Single Cylinder, Four Stroke, Two Valves, Air Cooled with SOHC (Single Over Head Cam) Chain Drive Bore & Stroke:47.0 x 49.5 MM",
            Price= 56900,
            DiscountPercentage= 13.63,
            Rating= 4.04,
            QuantityInStock= 115,
            Brand= "METRO 70cc Motorcycle - MR70",
            Category= "motorcycle",
            Thumbnail= "/images/products/products91thumbnail.jpg",
            Images=new string[]{
                "/images/products/products911.jpg",
                "/images/products/products912.jpg",
                "/images/products/products913.jpg",
                "/images/products/products914.jpg",
                "/images/products/products91thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Electric racing motorcycle",
            Description= "HOT SALE IN EUROPE electric racing motorcycle electric motorcycle for sale adult electric motorcycles",
            Price= 92000,
            DiscountPercentage= 14.4,
            Rating= 4.19,
            QuantityInStock= 22,
            Brand= "BRAVE BULL",
            Category= "motorcycle",
            Thumbnail= "/images/products/products92thumbnail.jpg",
            Images=new string[]{
                "/images/products/products921.jpg",
                "/images/products/products922.jpg",
                "/images/products/products923.jpg",
                "/images/products/products924.jpg"
            }
        },
        new Product
{
            Name= "Automatic Gas Motorcycles",
            Description= "150cc 4-Stroke Motorcycle Automatic Motor Gas Motorcycles Scooter motorcycles 150cc scooter",
            Price= 105000,
            DiscountPercentage= 3.34,
            Rating= 4.84,
            QuantityInStock= 127,
            Brand= "shock absorber",
            Category= "motorcycle",
            Thumbnail= "/images/products/products93thumbnail.jpg",
            Images=new string[]{
                "/images/products/products931.jpg",
                "/images/products/products932.jpg",
                "/images/products/products933.jpg",
                "/images/products/products934.jpg",
                "/images/products/products93thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Motocross goggles",
            Description= "new arrivals Fashion motocross goggles motorcycle motocross racing motorcycle",
            Price= 90000,
            DiscountPercentage= 3.85,
            Rating= 4.06,
            QuantityInStock= 109,
            Brand= "JIEPOLLY",
            Category= "motorcycle",
            Thumbnail= "/images/products/products94thumbnail.webp",
            Images=new string[]{
                "/images/products/products941.webp",
                "/images/products/products942.jpg",
                "/images/products/products943.jpg",
                "/images/products/products94thumbnail.webp"
            }
        },
        new Product
{
            Name= "Wholesale cargo Belt",
            Description= "Wholesale cargo lashing Belt Tie Down end Ratchet strap customized strap 25mm motorcycle 1500kgs with rubber handle",
            Price= 93000,
            DiscountPercentage= 17.67,
            Rating= 4.21,
            QuantityInStock= 144,
            Brand= "Xiangle",
            Category= "motorcycle",
            Thumbnail= "/images/products/products95thumbnail.jpg",
            Images=new string[]{
                "/images/products/products951.jpg",
                "/images/products/products952.jpg",
                "/images/products/products953.jpg",
                "/images/products/products954.jpg",
                "/images/products/products95thumbnail.jpg"
            }
        },
        new Product
{
            Name= "lighting ceiling kitchen",
            Description= "Wholesale slim hanging decorative kid room lighting ceiling kitchen chandeliers pendant light modern",
            Price= 3000,
            DiscountPercentage= 14.89,
            Rating= 4.83,
            QuantityInStock= 96,
            Brand= "lightingbrilliance",
            Category= "lighting",
            Thumbnail= "/images/products/products96thumbnail.jpg",
            Images=new string[]{
                "/images/products/products961.jpg",
                "/images/products/products962.jpg",
                "/images/products/products963.jpg",
                "/images/products/products964.jpg",
                "/images/products/products96thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Metal Ceramic Flower",
            Description= "Metal Ceramic Flower Chandelier Home Lighting American Vintage Hanging Lighting Pendant Lamp",
            Price= 3500,
            DiscountPercentage= 10.94,
            Rating= 4.93,
            QuantityInStock= 146,
            Brand= "Ifei Home",
            Category= "lighting",
            Thumbnail= "/images/products/products97thumbnail.jpg",
            Images=new string[]{
                "/images/products/products971.jpg",
                "/images/products/products972.jpg",
                "/images/products/products973.jpg",
                "/images/products/products974.webp",
                "/images/products/products97thumbnail.jpg"
            }
        },
        new Product
{
            Name= "lndenpant kitchen Lights",
            Description= "3 lights lndenpant kitchen islang dining room pendant rice paper chandelier contemporary led pendant light modern chandelier",
            Price= 3400,
            DiscountPercentage= 5.92,
            Rating= 4.99,
            QuantityInStock= 44,
            Brand= "DADAWU",
            Category= "lighting",
            Thumbnail= "/images/products/products98thumbnail.jpg",
            Images=new string[]{
                "/images/products/products981.jpg",
                "/images/products/products982.jpg",
                "/images/products/products983.jpg",
                "/images/products/products984.jpg",
                "/images/products/products98thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Vintage Pendant Light",
            Description= "American Vintage Wood Pendant Light Farmhouse Antique Hanging Lamp Lampara Colgante",
            Price= 4600,
            DiscountPercentage= 8.84,
            Rating= 4.32,
            QuantityInStock= 138,
            Brand= "Ifei Home",
            Category= "lighting",
            Thumbnail= "/images/products/products99thumbnail.jpg",
            Images=new string[]{
                "/images/products/products991.jpg",
                "/images/products/products992.jpg",
                "/images/products/products993.jpg",
                "/images/products/products994.jpg",
                "/images/products/products99thumbnail.jpg"
            }
        },
        new Product
{
            Name= "Crystal Theresa light",
            Description= "Crystal chandelier maria theresa for 12 light",
            Price= 4700,
            DiscountPercentage= 16,
            Rating= 4.74,
            QuantityInStock= 133,
            Brand= "YIOSI",
            Category= "lighting",
            Thumbnail= "/images/products/products100thumbnail.jpg",
            Images=new string[]{
                "/images/products/products1001.jpg",
                "/images/products/products1002.jpg",
                "/images/products/products1003.jpg",
                "/images/products/products100thumbnail.jpg"
            }
        }

            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}