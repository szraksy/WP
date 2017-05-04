#include "stdafx.h"
#include "Figure.h"


Figure::Figure(int radius, int x, int y)
{
	this->x = x;
	this->y = y;
	this->radius = radius;
}

Figure::~Figure()
{
}

void Figure::paint(HDC hdc)
{
	SelectObject(hdc, CreateSolidBrush(color));

	if (type == CIRCLE) {
		Ellipse(
			hdc,
			x - radius,
			y - radius,
			x + radius,
			y + radius
		);
	}
	else
	{

		RECT Recto = {
			x - radius,
			y - radius,
			x + radius,
			y + radius
		};

		FillRect(hdc, &Recto, (HBRUSH)(color));
	}
}

void Figure::setRandomColor()
{
	color = RGB(rand() % 256, rand() % 256, rand() % 256);
}


void Figure::setRandomVelocity()
{
	velocityX = (rand() % 40 + 3) * ((rand() % 2) ? -1 : 1);
	velocityY = (rand() % 40 + 3) * ((rand() % 2) ? -1 : 1);
}


void Figure::setRandomRadius()
{
	radius = 15 + rand() % 10;
}

void Figure::setSquare()
{
	type = SQUARE;
}

void Figure::setCircle()
{
	type = CIRCLE;
}

void Figure::update()
{
	x += velocityX;
	y += velocityY;
}


bool Figure::collides(Figure figure)
{
	if (sqrt(pow(x - figure.x, 2) + pow(y - figure.y, 2)) <= radius + figure.radius)
		return true;
	return false;
}

void Figure::invertVelocityX()
{
	velocityX *= -1;
}

void Figure::invertVelocityY()
{
	velocityY *= -1;
}

bool Figure::collidesVerticalLine(int x)
{
	if (x == 0)
	{
		if (this->x < 0)
			return true;
	}
	else
	{
		if (this->x > x)
			return true;
	}
	if (abs(this->x - x) <= radius)
		return true;
	return false;
}

bool Figure::collidesHorizontalLine(int y)
{
	if (y == 0)
	{
		if (this->y < 0)
			return true;
	}
	else
	{
		if (this->y > y)
			return true;
	}
	if (abs(this->y - y) <= radius)
		return true;
	return false;
}

