
#define GLSLSANDBOX
#ifdef GLSLSANDBOX
#ifdef GL_ES
precision mediump float;
#endif
uniform float time;
#ifndef GLSLSANDBOXTOYNOTCOMPATIBLE
uniform vec4 iMouse;
uniform int iFrame;
#else /*GLSLSANDBOXTOYNOTCOMPATIBLE*/
uniform vec2 mouse;
#define iMouse mouse
#endif /*GLSLSANDBOXTOYNOTCOMPATIBLE*/
uniform vec2 resolution;
#define iGlobalTime time
#define iResolution (vec3(resolution, 1.))
#endif /*GLSLSANDBOX*/



// My first drawing with glsl
// Trying to make a boat, floating on the sea....

void rotate(inout vec2 p, float a, vec2 center) {
    p -= center;
    p *= mat2(cos(a), -sin(a), sin(a), cos(a));
    p += center;
}

float body(in vec2 p) {
    // Scale and position body    
    p.x -= 0.5;
    p.y *= 1.8;
    p.x *= 1.5;
    
    float f = 1.;
    
    // Shape
    f *= smoothstep(0.3, 0.31, p.y);
    f *= 1. - smoothstep(0.6, 0.61, p.y);
    f *= 1. - smoothstep(0.3, 0.31, abs(p.x) - (p.y * 0.5 - 0.2));
    
    return f;
}

float pole(in vec2 p) {    
    float f = 1.;
    
    p.y -= 0.2;
    p.x -= 0.5;
    p.x *= 10.5;
    
    f *= 1. - smoothstep(0.1, 0.11, abs(p.x));
    f *= step(0.0, p.y);
    f *= 1. - smoothstep(0.6, 0.61, p.y);
    
    return f;
}

float sail1(in vec2 p) {    
    float f = 1.0;
    
    p.y -= 0.40;
    p.x -= 0.512;
    p.y *= 3.78;
    p.x *= 1.5;
    
    f *= smoothstep(0., 0.01, p.x);
    f *= smoothstep(0., 0.01, p.y);
    f *= 1. - smoothstep(0.3, 0.31, p.x + p.y * 0.2);
    
    return f;
}

float sail2(in vec2 p) {    
    float f = 1.0;
    
    p.y -= 0.40;
    p.x -= 0.488;
    p.y *= 4.;
    p.x *= -2.;
    
    f *= smoothstep(0., 0.01, p.x);
    f *= smoothstep(0., 0.01, p.y);
    f *= 1. - smoothstep(0.3, 0.31, p.x + p.y * 0.2);
    
    return f;
}




// rendering params
const float sphsize=.7; // planet size
const float dist=.77; // distance for glow and distortion
const float perturb=0.55; // distortion amount of the flow around the planet
const float displacement=0.50; // hot air effect
const float windspeed=.1; // speed of wind flow
const float steps=110.; // number of steps for the volumetric rendering
const float stepsize=.025; 
const float brightness=.56;
const vec3 planetcolor=vec3(0.55,0.4,0.3);
const float fade=.005; //fade by distance
const float glow=2.0; // glow amount, mainly on hit side


// fractal params
const int iterations=13; 
const float fractparam=.7;
const vec3 offset=vec3(1.5,2.,-1.5);


float wind(vec3 p) 
{
    float d=max(0.0,dist-max(0.,length(p)-sphsize)/sphsize)/dist; // for distortion and glow area
    float x=max(0.8,p.x*0.5); // to increase glow on left side
    
    p.y*=1.+max(0.2,-p.x-sphsize*0.70)*10.; // left side distortion (cheesy)
    p-=d*normalize(p)*perturb; // spheric distortion of flow
    p+=vec3(iGlobalTime*windspeed,0.5,0.5); // flow movement
    p=abs(fract((p+offset)*.1)-.5); // tile folding 
    for (int i=0; i<iterations; i++) 
    {  
        p=abs(p)/dot(p,p)-fractparam; // the magic formula for the hot flow
    }
    return length(p)*(1.+d*glow*x)+d*glow*x; // return the result with glow applied
}

vec3 bti( in vec2 fragCoord )
{
    // get ray dir  
    vec2 uv = fragCoord-0.4;
    vec3 dir=vec3(uv,0.9);
    dir.x*=iResolution.x/iResolution.y;
    vec3 from=vec3(0.,0.,-2.);;
    

    // volumetric rendering
    float v=0., l=-0.0001, t=iGlobalTime*windspeed*.2;
    for (float r=15.;r<steps;r++)
    {
        vec3 p=from+r*dir*stepsize;
        v+=min(10.,wind(p))*max(0.,1.-r*fade); 

    }
   
    v/=steps; v*=brightness; // average values and apply bright factor
    vec3 col=vec3(v*1.25,v*v,v*v*v)+l*planetcolor; // set color
    col*=1.-length(pow(abs(uv),vec2(5.)))*14.; // vignette (kind of)
    
    return col;
}




vec3 boat(in vec3 background, in vec2 p) {
    vec3 color = background;
    
    p.x *= 0.8;
    p.x -= 0.2;
    p.y += cos(iGlobalTime * 1.3) * 0.04;
    rotate(p, sin(iGlobalTime) * 0.2, vec2(0.5, 0.1));
    color = mix(color, bti(p) , pole(p));
    color = mix(color, bti(p) + vec3(-0.2) * p.y, sail1(p));
    color = mix(color, bti(p) + vec3(-0.2) * p.y, sail2(p));
    color = mix(color, bti(p), body(p));     


    return color;
}



vec3 fr(in vec2 p ) {

    float timeScroll = iGlobalTime* 1.0;
    float sinusCurve = sin((p.x*2.0+timeScroll)/0.5)*0.3;
    
    p = (p*2.+0.00) + vec2(0.0, sinusCurve);
    
    float line = abs(0.1 /p.y);
    
    vec3 color = vec3(sin(iGlobalTime)*line,cos(iGlobalTime)*line,sin(iGlobalTime)*cos(line));
    
    return color;

}


vec3 water(in vec3 background, in vec2 p) {
    vec3 color = vec3(1.1, 0.3, 0.0);
    
    p.y -= 0.13;
    
    float f = 1. - smoothstep(0.1, 0.11,
                         p.y + sin(p.x * 20. + iGlobalTime * 2.)
                         * 0.03 * cos(p.x * 5. + iGlobalTime * 2.));
    

    color = mix(background, color+fr(p.xy+0.1), f);

    
    return color;   
    
}

vec3 bg1(in vec2 fragCoord )
{
    vec2  px = 4.0*(-iResolution.xy + 2.0*fragCoord.xy) / iResolution.y;
    
    float id = 0.5 + 0.5*cos(iGlobalTime + sin(dot(floor(px+0.5),vec2(113.1,17.81)))*43758.545);
    
    vec3  co = 0.5 + 0.5*cos(iGlobalTime + 3.5*id + vec3(0.0,1.57,3.14) );
    
    vec2  pa = smoothstep( 0.0, 0.2, id*(0.5 + 0.5*cos(6.2831*px)) );
    
    return vec3( co*pa.x*pa.y );
}



#define FIELD 20.0
#define HEIGHT 0.7
#define ITERATION 2
#define TONE vec3(0.5,0.2,0.3)

vec2 eq(vec2 p,float t){
    vec2 fx = vec2(0.0);
    fx.x = (sin(p.y+cos(t+p.x*0.2))*cos(p.x-t));
    fx.x *= acos(fx.x);
    fx.x *= -distance(fx.x,0.5)*p.x/p.y;
    fx.y = p.y-fx.x;
    return fx;
}

vec3 computeColor(vec2 p, float t, float hs){
    vec3 color = vec3(0.0);
    vec2 fx = eq(p,t);
    for(int i=0; i<ITERATION; ++i)
    {
        p.x+=p.x;
        color.r += TONE.r/length(fx.y-fx.x-hs);
        fx.x += eq(p,t+float(i+1)).x;
        color.g += TONE.g/length(fx.y-fx.x-hs);
        fx.x += eq(p,t+float(i+2)).x;
        color.b += TONE.b/length(fx.y-fx.x-hs);
    }
    return color;
}

vec3 bg2(in vec2 fragCoord ) {
    float time = iGlobalTime;
    vec2 position = ( fragCoord.xy / iResolution.xy )+0.5;
    float hs = FIELD*(HEIGHT+cos(time)*0.1);
    vec2 p = (position)*FIELD;
    vec3 color = computeColor(p, time, hs);
    return  color;
}



void mainImage( out vec4 fragColor, in vec2 fragCoord )
{
    vec2 p = fragCoord.xy / iResolution.xy;
    // Fix ratio
    p.x *= iResolution.x / iResolution.y;
    
    vec3 color = vec3(0.);    
    
    // Background
    color += mix(vec3(0.58, 0.0, 0.0), bg1(fragCoord)/bg2(fragCoord), sqrt(p.y) - 0.5);
    
    color = boat(color, p);
    color = water(color, p);
    
    fragColor = vec4(color,1.0);
}

#ifdef GLSLSANDBOX
void main() {
  mainImage(gl_FragColor, gl_FragCoord.xy);
}
#endif /*GLSLSANDBOX*/
