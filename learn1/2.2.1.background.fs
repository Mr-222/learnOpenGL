#version 330 core
out vec4 FragColor;

in vec3 localPos;

uniform samplerCube environmentMap;

void main()
{
	//vec3 envColor = texture(environmentMap, localPos).rgb;
	vec3 envColor = textureLod(environmentMap, localPos, 0.0).rgb;
	envColor = envColor / (envColor + vec3(1.0));
	envColor = pow(envColor, vec3(1.0/2.2));
	FragColor = vec4(envColor, 1.0);
}