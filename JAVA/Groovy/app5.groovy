@Grab("thymeleaf-spring4")
@Controller
class App{

	@RequestMapping("/")
	@ResponseBody
	def home(ModelAndView mav){
		mav.setViewName("home")
		mav.addObject("msg","U+E38193U+E38293U+E381ABU+E381A1U+E381AF")
	}
}