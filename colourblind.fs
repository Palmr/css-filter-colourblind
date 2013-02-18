precision mediump float;
uniform float t; // type of colourblindness to emulate

void main() {
  // The shader spec doesn't seem to include the switch statement or elseif :(
  if (t == 1.0) { // protanopia
    css_ColorMatrix = mat4( 0.567, 0.433, 0,      0.0,
                            0.558, 0.442, 0,      0.0,
                            0    , 0.242, 0.758,  0.0,
                            0.0  , 0.0  , 0.0  ,  1.0 );
  }
  else {
    if (t == 2.0) { // protanomaly
      css_ColorMatrix = mat4( 0.817, 0.183, 0    , 0.0,
                              0.333, 0.667, 0    , 0.0,
                              0    , 0.125 ,0.875, 0.0,
                              0.0  , 0.0  , 0.0  ,  1.0 );
    }
    else {
      if (t == 3.0) { // deuteranopia
        css_ColorMatrix = mat4( 0.625, 0.375, 0    , 0.0,
                                0.7  , 0.3  , 0    , 0.0,
                                0    , 0.3   ,0.7  , 0.0,
                                0.0  , 0.0  , 0.0  ,  1.0 );
      }
      else {
        if (t == 4.0) { // deuteranomaly
          css_ColorMatrix = mat4( 0.8  , 0.2  , 0    ,  0.0,
                                  0.258, 0.742, 0    ,  0.0,
                                  0    , 0.142 ,0.858,  0.0,
                                  0.0  , 0.0  , 0.0  ,  1.0 );
        }
        else {
          if (t == 5.0) { // tritanopia
            css_ColorMatrix = mat4( 0.95 , 0.05 , 0    ,  0.0,
                                    0    , 0.433, 0.567,  0.0,
                                    0    , 0.475 ,0.525,  0.0,
                                    0.0  , 0.0  , 0.0  ,  1.0 );
          }
          else {
            if (t == 6.0) { // tritanomaly
              css_ColorMatrix = mat4( 0.967, 0.033, 0    ,  0.0,
                                      0    , 0.733, 0.267,  0.0,
                                      0    , 0.183 ,0.817,  0.0,
                                      0.0  , 0.0  , 0.0  ,  1.0 );
            }
            else {
              if (t == 7.0) { // achromatopsia
                css_ColorMatrix = mat4( 0.299, 0.587, 0.114,  0.0,
                                        0.299, 0.587, 0.114,  0.0,
                                        0.299, 0.587 ,0.114,  0.0,
                                        0.0  , 0.0  , 0.0  ,  1.0 );
              }
              else {
                if (t == 8.0) { // achromatomaly
                  css_ColorMatrix = mat4( 0.618, 0.320, 0.062,  0.0,
                                          0.163, 0.775, 0.062,  0.0,
                                          0.163, 0.320 ,0.516,  0.0,
                                          0.0  , 0.0  , 0.0  ,  1.0 );
                }
                else {
                  css_ColorMatrix = mat4( 1.0, 0.0, 0.0, 0.0,
                                          0.0, 1.0, 0.0, 0.0,
                                          0.0, 0.0, 1.0, 0.0,
                                          0.0, 0.0, 0.0, 1.0 );
                }
              }
            }
          }
        }
      }
    }
  }
}