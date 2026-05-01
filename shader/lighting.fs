#version 330 core
in vec3 normal;
in vec2 texCoord;
in vec3 position;
out vec4 fragColor;

uniform vec3 lightPos;
uniform vec3 lightColor; //광원색상
uniform vec3 objectColor; // 오브젝트 색상
uniform float ambientStrength;

void main() {
  vec3 ambient = ambientStrength * lightColor;
	vec3 lightDir = normalize(lightPos - position);
  vec3 pixelNorm = normalize(normal);
  vec3 diffuse = max(dot(pixelNorm, lightDir), 0.0) * lightColor;
  vec3 result = (ambient + diffuse) * objectColor;
  fragColor = vec4(result, 1.0);
}