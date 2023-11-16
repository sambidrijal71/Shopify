import { Carousel } from 'react-responsive-carousel';
const images = [
  { name: 'carousel1', path: '../../../public/images/carousel/Carousel1.jpg' },
  { name: 'carousel2', path: '../../../public/images/carousel/Carousel2.jpg' },
  { name: 'carousel3', path: '../../../public/images/carousel/Carousel3.jpg' },
  { name: 'carousel4', path: '../../../public/images/carousel/Carousel4.jpg' },
  { name: 'carousel5', path: '../../../public/images/carousel/Carousel5.jpg' },
  { name: 'carousel6', path: '../../../public/images/carousel/Carousel6.jpg' },
  { name: 'carousel7', path: '../../../public/images/carousel/Carousel7.jpg' },
  { name: 'carousel8', path: '../../../public/images/carousel/Carousel8.jpg' },
];
const HomePage = () => {
  return (
    <Carousel
      infiniteLoop
      autoPlay
      showArrows={true}
      showThumbs={false}
      stopOnHover
    >
      {images.map((image) => (
        <div key={image.name}>
          <img src={image.path} alt={image.name} height={'400px'} />
        </div>
      ))}
    </Carousel>
  );
};

export default HomePage;
