$ (document).ready (function () {
  console.log ($ ('#sidebar'));
  console.log ($ ('.post'));

  function clickPost () {
    console.log ('clicked post');
  }
  $ ('.post').on ('click', function () {
    console.log ('clicked');
  });
  //добавляет стиль
  // $("button").on("click", function() {
  //     $("p").toggleClass("myclass");
  // });
  // $("button").on("click", function() {
  //     $(".lorem").fadeOut();
  //     $(".lorem").fadeIn();
  // });
  //клик
//   $ ('button').on ('click', function () {
//     $ ('.lorem').slideToggle ();
//   });
  $ (document).on ('scroll', scrollBy);

  $ ('.lorem').on ('mouseleave');

  $ ('p.lorem').nextAll ().css ({color: 'blue', border: '2px solid red'});

//   $ ('button').on ('click', function () {    
//     $ ('p').animate({left: '250px'});
//   });

  $ ('button').on ('click', function () {    
    $ ('button').animate({width: '300px', height: '200px'});
  });
});
