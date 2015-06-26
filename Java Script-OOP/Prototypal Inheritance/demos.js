/**
 * Created by Aleksandra on 6/24/2015.
 */
var animal = {
    makeNoise: function(){
        console.log('The ' + this.type + ' makes noise "'  + this.noise + '"');
    }
};

var dog1= {
    type: 'dog',
    noise: 'Djaf'
};
dog1.__proto__=animal;
dog1.makeNoise();
animal.makeNoise();
//..........................................................................................
//var dog=(function(parent){
//    var dog=Object.defineProperties(parent,{
//       type:{
//           value:'dog'
//       },
//        noise:{
//            value:'Djaf'
//        },
//        bark:{
//            value:function(){
//                console.log('Bark, bark');
//            }
//        }
//    });
//    return dog;
//}(animal));
//dog.makeNoise();
//animal.makeNoise();//tva tuka i animal go racuna kako dog?????
//..........................................................................................
var dogyy=Object.create(animal);
dogyy.type='dog';
dogyy.noise='Djaf';
dogyy.makeNoise();
animal.makeNoise();
